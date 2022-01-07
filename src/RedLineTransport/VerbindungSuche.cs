using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Models;
using SwissTransport.Core;


namespace RedLineTransport
{

    public partial class VerbindungSuche : Form
    {
        private readonly ITransport transport = new Transport();
        private readonly BindingList<string> suggestions = new BindingList<string>();

        public VerbindungSuche()
        {
            InitializeComponent();
            AbfahrtstabellePanel.Visible = false;
            this.AutoErgaenzung.DataSource = this.suggestions;
            this.AutoErgaenzungZiel.DataSource = this.suggestions;
            this.AutoErgaenzungAbfahrt.DataSource = this.suggestions;
            AutoErgaenzung.Visible = false;
            AutoErgaenzungZiel.Visible = false;
            AutoErgaenzungAbfahrt.Visible = false;
            this.StartStandortTextbox.LostFocus += this.StartStandortTextbox_LostFocus;
            this.ZielStandortTextbox.LostFocus += this.ZielStandortTextbox_LostFocus;
            this.AbfahrtstabelleTextbox.LostFocus += this.AbfahrtstabelleTextbox_LostFocus;

        }

        private void AbfahrtstabelleTextbox_LostFocus(object? sender, EventArgs e)
        {
            AutoErgaenzungAbfahrt.Visible = false;
        }

        private void ZielStandortTextbox_LostFocus(object? sender, EventArgs e)
        {
            AutoErgaenzungZiel.Visible = false;
        }

        private void StartStandortTextbox_LostFocus(object? sender, EventArgs e)
        {
            AutoErgaenzung.Visible = false;
        }

        private void AbfahrtstabelleZeigenButton_Click(object sender, EventArgs e)
        {
            VerbindungsSuchePanel.Visible = false;
            AbfahrtstabellePanel.Visible = true;
            AbfahrtstabelleTextbox.TabIndex = 1;
            AbfahrtSuchenButton.TabIndex = 2;
        }
        private void VerbindungssucheAnzeigen_Click(object sender, EventArgs e)
        {
            VerbindungsSuchePanel.Visible = true;
            AbfahrtstabellePanel.Visible = false;
            VerbindungSuchenButton.TabIndex = 3;
            StartStandortTextbox.TabIndex = 1;
            ZielStandortTextbox.TabIndex = 2;
        }
        private void KarteZeigenButton_Click(object sender, EventArgs e)
        {

        }



        
        private readonly Formatting format = new Formatting();
        private void VerbindungSuchenButton_Click(object sender, EventArgs e)
        {
            string startStandortEingabe = StartStandortTextbox.Text;
            string zielStandortEingabe = ZielStandortTextbox.Text;

            Connections Verbindung = this.transport
                .GetConnections(startStandortEingabe, zielStandortEingabe);

            var wertList = Verbindung.ConnectionList
                .Select(x => new RecordForVerbindungssucheDataGrid(x.To.Station.Name, x.From.Station.Name,format.ShortenTime(x.From.Departure), format.ShortenDurationTime(x.Duration), format.ShortenTime(x.To.Arrival)))
                .ToList();


            var bindingDataGridList = new BindingList<RecordForVerbindungssucheDataGrid>(wertList);

            VerbindungDataGrid.DataSource = bindingDataGridList;


            if (Verbindung == null)
            {
                //Keine Verbindungen Ausgeben
            }
        }

        private void AbfahrtSuchenButton_Click(object sender, EventArgs e)
        {
            string startStationInput = this.AbfahrtstabelleTextbox.Text;



            Stations Station = this.transport
                .GetStations(startStationInput);


            var id = Station.StationList
                .Select(Value => new RecordForAbfahrtId(Value.Id))
                .ToString();

            StationBoardRoot StationBoardRoot = this.transport
                .GetStationBoard(startStationInput, id);


            var values = StationBoardRoot.Entries
                .Select(Value => new RecordForAbfahrtDataGrid(Value.Name, Value.Category, Value.Number, Value.To, Value.Operator, format.ShortenTime(Value.Stop.Departure)))
                .ToList();

            var bindingList = new BindingList<RecordForAbfahrtDataGrid>(values);
            AbfahrtstabelleDataGrid.DataSource = bindingList;
        
        }


        private void StartStandortTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.StartStandortTextbox.Text))
            {
                return;
            }

            string stationQuery = this.StartStandortTextbox.Text;

            Stations result = this.transport.GetStations(stationQuery);
            this.suggestions.Clear();
            foreach (var station in result.StationList)
            {
                this.suggestions.Add(station.Name);
            }

            this.AutoErgaenzung.Visible = true;
        }
        private void AutoErgaenzung_MouseClick(object sender, MouseEventArgs e)
        {
            for (var index = 0; index < this.AutoErgaenzung.Items.Count; index++)
            {
                if (this.AutoErgaenzung.GetItemRectangle(index).Contains(e.Location))
                {
                    this.StartStandortTextbox.Text = this.AutoErgaenzung.Items[index].ToString();
                }
            }

            this.AutoErgaenzung.Visible = false;
        }
        private void AutoErgaenzung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && this.AutoErgaenzung.Visible && this.AutoErgaenzung.SelectedItem != null)
            {
                this.StartStandortTextbox.Text = this.AutoErgaenzung.SelectedItem.ToString();
                this.StartStandortTextbox.Select(this.StartStandortTextbox.Text!.Length, 0);
            }
        }

        private void ZielStandortTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.ZielStandortTextbox.Text))
            {
                return;
            }

            string stationQuery = this.ZielStandortTextbox.Text;

            Stations result = this.transport.GetStations(stationQuery);
            this.suggestions.Clear();
            foreach (var station in result.StationList)
            {
                this.suggestions.Add(station.Name);
            }

            this.AutoErgaenzungZiel.Visible = true;
        }

        private void AutoErgaenzungZiel_MouseClick(object sender, MouseEventArgs e)
        {
            for (var index = 0; index < this.AutoErgaenzungZiel.Items.Count; index++)
            {
                if (this.AutoErgaenzungZiel.GetItemRectangle(index).Contains(e.Location))
                {
                    this.ZielStandortTextbox.Text = this.AutoErgaenzungZiel.Items[index].ToString();
                }
            }

            this.AutoErgaenzungZiel.Visible = false;
        }

        private void AutoErgaenzungZiel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && this.AutoErgaenzungZiel.Visible && this.AutoErgaenzungZiel.SelectedItem != null)
            {
                this.ZielStandortTextbox.Text = this.AutoErgaenzungZiel.SelectedItem.ToString();
                this.ZielStandortTextbox.Select(this.ZielStandortTextbox.Text!.Length, 0);
            }
        }

        private void AbfahrtstabelleTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.AbfahrtstabelleTextbox.Text))
            {
                return;
            }

            string stationQuery = this.AbfahrtstabelleTextbox.Text;

            Stations result = this.transport.GetStations(stationQuery);
            this.suggestions.Clear();
            foreach (var station in result.StationList)
            {
                this.suggestions.Add(station.Name);
            }

            this.AutoErgaenzungAbfahrt.Visible = true;
        }

        private void AutoErgaenzungAbfahrt_MouseClick(object sender, MouseEventArgs e)
        {
            for (var index = 0; index < this.AutoErgaenzungAbfahrt.Items.Count; index++)
            {
                if (this.AutoErgaenzungAbfahrt.GetItemRectangle(index).Contains(e.Location))
                {
                    this.AbfahrtstabelleTextbox.Text = this.AutoErgaenzungAbfahrt.Items[index].ToString();
                }
            }

            this.AutoErgaenzungAbfahrt.Visible = false;
        }

        private void AutoErgaenzungAbfahrt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && this.AutoErgaenzungAbfahrt.Visible && this.AutoErgaenzungAbfahrt.SelectedItem != null)
            {
                this.AbfahrtstabelleTextbox.Text = this.AutoErgaenzungAbfahrt.SelectedItem.ToString();
                this.AbfahrtstabelleTextbox.Select(this.AbfahrtstabelleTextbox.Text!.Length, 0);
            }
        }



        private record RecordForVerbindungssucheDataGrid(string To, string From,string Departure, string Duration, string Arrival);
        private record RecordForAbfahrtId(string id);

        private record RecordForAbfahrtDataGrid(string name, string category, string number, string To, string Operator, string Stop);
    }
}
