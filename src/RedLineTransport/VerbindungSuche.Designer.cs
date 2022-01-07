namespace RedLineTransport
{
    partial class VerbindungSuche
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerbindungSuche));
            this.label1 = new System.Windows.Forms.Label();
            this.StartStandortLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ZielStandortTextbox = new System.Windows.Forms.TextBox();
            this.VerbindungSuchenButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Label();
            this.AbfahrtstabelleZeigenButton = new System.Windows.Forms.Button();
            this.StartStandortTextbox = new System.Windows.Forms.TextBox();
            this.VerbindungDataGrid = new System.Windows.Forms.DataGridView();
            this.VerbindungsSuchePanel = new System.Windows.Forms.Panel();
            this.AutoErgaenzungZiel = new System.Windows.Forms.ListBox();
            this.AutoErgaenzung = new System.Windows.Forms.ListBox();
            this.AbfahrtstabellePanel = new System.Windows.Forms.Panel();
            this.AutoErgaenzungAbfahrt = new System.Windows.Forms.ListBox();
            this.AbfahrtstabelleTextbox = new System.Windows.Forms.TextBox();
            this.AbfahrtstabelleDataGrid = new System.Windows.Forms.DataGridView();
            this.AbfahrtstabelleLabel = new System.Windows.Forms.Label();
            this.AbfahrtSuchenButton = new System.Windows.Forms.Button();
            this.VerbindungssucheAnzeigen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungDataGrid)).BeginInit();
            this.VerbindungsSuchePanel.SuspendLayout();
            this.AbfahrtstabellePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbfahrtstabelleDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(395, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ziel Standort";
            // 
            // StartStandortLabel
            // 
            this.StartStandortLabel.AutoSize = true;
            this.StartStandortLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartStandortLabel.Location = new System.Drawing.Point(41, 7);
            this.StartStandortLabel.Name = "StartStandortLabel";
            this.StartStandortLabel.Size = new System.Drawing.Size(124, 20);
            this.StartStandortLabel.TabIndex = 12;
            this.StartStandortLabel.Text = "Start Standort";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ZielStandortTextbox
            // 
            this.ZielStandortTextbox.BackColor = System.Drawing.Color.White;
            this.ZielStandortTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZielStandortTextbox.Location = new System.Drawing.Point(377, 31);
            this.ZielStandortTextbox.Name = "ZielStandortTextbox";
            this.ZielStandortTextbox.Size = new System.Drawing.Size(166, 27);
            this.ZielStandortTextbox.TabIndex = 2;
            this.ZielStandortTextbox.TextChanged += new System.EventHandler(this.ZielStandortTextbox_TextChanged);
            // 
            // VerbindungSuchenButton
            // 
            this.VerbindungSuchenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.VerbindungSuchenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.VerbindungSuchenButton.FlatAppearance.BorderSize = 0;
            this.VerbindungSuchenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VerbindungSuchenButton.Location = new System.Drawing.Point(377, 64);
            this.VerbindungSuchenButton.Name = "VerbindungSuchenButton";
            this.VerbindungSuchenButton.Size = new System.Drawing.Size(166, 29);
            this.VerbindungSuchenButton.TabIndex = 8;
            this.VerbindungSuchenButton.Text = "Verbindung suchen";
            this.VerbindungSuchenButton.UseVisualStyleBackColor = false;
            this.VerbindungSuchenButton.Click += new System.EventHandler(this.VerbindungSuchenButton_Click);
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Rockwell Nova", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Logo.Location = new System.Drawing.Point(3, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(150, 44);
            this.Logo.TabIndex = 7;
            this.Logo.Text = "RedLine";
            // 
            // AbfahrtstabelleZeigenButton
            // 
            this.AbfahrtstabelleZeigenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AbfahrtstabelleZeigenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AbfahrtstabelleZeigenButton.FlatAppearance.BorderSize = 0;
            this.AbfahrtstabelleZeigenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AbfahrtstabelleZeigenButton.Location = new System.Drawing.Point(3, 211);
            this.AbfahrtstabelleZeigenButton.Name = "AbfahrtstabelleZeigenButton";
            this.AbfahrtstabelleZeigenButton.Size = new System.Drawing.Size(191, 66);
            this.AbfahrtstabelleZeigenButton.TabIndex = 5;
            this.AbfahrtstabelleZeigenButton.Text = "Abfahrtstabelle";
            this.AbfahrtstabelleZeigenButton.UseVisualStyleBackColor = false;
            this.AbfahrtstabelleZeigenButton.Click += new System.EventHandler(this.AbfahrtstabelleZeigenButton_Click);
            // 
            // StartStandortTextbox
            // 
            this.StartStandortTextbox.Location = new System.Drawing.Point(40, 30);
            this.StartStandortTextbox.Name = "StartStandortTextbox";
            this.StartStandortTextbox.Size = new System.Drawing.Size(125, 27);
            this.StartStandortTextbox.TabIndex = 1;
            this.StartStandortTextbox.TextChanged += new System.EventHandler(this.StartStandortTextbox_TextChanged);
            // 
            // VerbindungDataGrid
            // 
            this.VerbindungDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerbindungDataGrid.Location = new System.Drawing.Point(20, 114);
            this.VerbindungDataGrid.Name = "VerbindungDataGrid";
            this.VerbindungDataGrid.ReadOnly = true;
            this.VerbindungDataGrid.RowHeadersWidth = 51;
            this.VerbindungDataGrid.RowTemplate.Height = 29;
            this.VerbindungDataGrid.Size = new System.Drawing.Size(523, 234);
            this.VerbindungDataGrid.TabIndex = 19;
            // 
            // VerbindungsSuchePanel
            // 
            this.VerbindungsSuchePanel.Controls.Add(this.AutoErgaenzungZiel);
            this.VerbindungsSuchePanel.Controls.Add(this.AutoErgaenzung);
            this.VerbindungsSuchePanel.Controls.Add(this.StartStandortTextbox);
            this.VerbindungsSuchePanel.Controls.Add(this.VerbindungDataGrid);
            this.VerbindungsSuchePanel.Controls.Add(this.StartStandortLabel);
            this.VerbindungsSuchePanel.Controls.Add(this.pictureBox1);
            this.VerbindungsSuchePanel.Controls.Add(this.VerbindungSuchenButton);
            this.VerbindungsSuchePanel.Controls.Add(this.ZielStandortTextbox);
            this.VerbindungsSuchePanel.Controls.Add(this.label1);
            this.VerbindungsSuchePanel.Location = new System.Drawing.Point(200, 87);
            this.VerbindungsSuchePanel.Name = "VerbindungsSuchePanel";
            this.VerbindungsSuchePanel.Size = new System.Drawing.Size(588, 351);
            this.VerbindungsSuchePanel.TabIndex = 20;
            // 
            // AutoErgaenzungZiel
            // 
            this.AutoErgaenzungZiel.FormattingEnabled = true;
            this.AutoErgaenzungZiel.ItemHeight = 20;
            this.AutoErgaenzungZiel.Location = new System.Drawing.Point(377, 55);
            this.AutoErgaenzungZiel.Name = "AutoErgaenzungZiel";
            this.AutoErgaenzungZiel.Size = new System.Drawing.Size(197, 104);
            this.AutoErgaenzungZiel.TabIndex = 21;
            this.AutoErgaenzungZiel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AutoErgaenzungZiel_MouseClick);
            this.AutoErgaenzungZiel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoErgaenzungZiel_KeyPress);
            // 
            // AutoErgaenzung
            // 
            this.AutoErgaenzung.FormattingEnabled = true;
            this.AutoErgaenzung.ItemHeight = 20;
            this.AutoErgaenzung.Location = new System.Drawing.Point(40, 55);
            this.AutoErgaenzung.Name = "AutoErgaenzung";
            this.AutoErgaenzung.Size = new System.Drawing.Size(181, 104);
            this.AutoErgaenzung.TabIndex = 20;
            this.AutoErgaenzung.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AutoErgaenzung_MouseClick);
            this.AutoErgaenzung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoErgaenzung_KeyPress);
            // 
            // AbfahrtstabellePanel
            // 
            this.AbfahrtstabellePanel.Controls.Add(this.AutoErgaenzungAbfahrt);
            this.AbfahrtstabellePanel.Controls.Add(this.AbfahrtstabelleTextbox);
            this.AbfahrtstabellePanel.Controls.Add(this.AbfahrtstabelleDataGrid);
            this.AbfahrtstabellePanel.Controls.Add(this.AbfahrtstabelleLabel);
            this.AbfahrtstabellePanel.Controls.Add(this.AbfahrtSuchenButton);
            this.AbfahrtstabellePanel.Location = new System.Drawing.Point(200, 87);
            this.AbfahrtstabellePanel.Name = "AbfahrtstabellePanel";
            this.AbfahrtstabellePanel.Size = new System.Drawing.Size(599, 351);
            this.AbfahrtstabellePanel.TabIndex = 21;
            // 
            // AutoErgaenzungAbfahrt
            // 
            this.AutoErgaenzungAbfahrt.FormattingEnabled = true;
            this.AutoErgaenzungAbfahrt.ItemHeight = 20;
            this.AutoErgaenzungAbfahrt.Location = new System.Drawing.Point(210, 86);
            this.AutoErgaenzungAbfahrt.Name = "AutoErgaenzungAbfahrt";
            this.AutoErgaenzungAbfahrt.Size = new System.Drawing.Size(181, 104);
            this.AutoErgaenzungAbfahrt.TabIndex = 21;
            this.AutoErgaenzungAbfahrt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AutoErgaenzungAbfahrt_MouseClick);
            this.AutoErgaenzungAbfahrt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoErgaenzungAbfahrt_KeyPress);
            // 
            // AbfahrtstabelleTextbox
            // 
            this.AbfahrtstabelleTextbox.Location = new System.Drawing.Point(210, 55);
            this.AbfahrtstabelleTextbox.Name = "AbfahrtstabelleTextbox";
            this.AbfahrtstabelleTextbox.Size = new System.Drawing.Size(149, 27);
            this.AbfahrtstabelleTextbox.TabIndex = 1;
            this.AbfahrtstabelleTextbox.TextChanged += new System.EventHandler(this.AbfahrtstabelleTextbox_TextChanged);
            // 
            // AbfahrtstabelleDataGrid
            // 
            this.AbfahrtstabelleDataGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.AbfahrtstabelleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbfahrtstabelleDataGrid.Location = new System.Drawing.Point(20, 108);
            this.AbfahrtstabelleDataGrid.Name = "AbfahrtstabelleDataGrid";
            this.AbfahrtstabelleDataGrid.ReadOnly = true;
            this.AbfahrtstabelleDataGrid.RowHeadersWidth = 51;
            this.AbfahrtstabelleDataGrid.RowTemplate.Height = 29;
            this.AbfahrtstabelleDataGrid.Size = new System.Drawing.Size(541, 234);
            this.AbfahrtstabelleDataGrid.TabIndex = 19;
            // 
            // AbfahrtstabelleLabel
            // 
            this.AbfahrtstabelleLabel.AutoSize = true;
            this.AbfahrtstabelleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AbfahrtstabelleLabel.Location = new System.Drawing.Point(210, 12);
            this.AbfahrtstabelleLabel.Name = "AbfahrtstabelleLabel";
            this.AbfahrtstabelleLabel.Size = new System.Drawing.Size(149, 20);
            this.AbfahrtstabelleLabel.TabIndex = 12;
            this.AbfahrtstabelleLabel.Text = "Abfahrtsstandort";
            // 
            // AbfahrtSuchenButton
            // 
            this.AbfahrtSuchenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AbfahrtSuchenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AbfahrtSuchenButton.FlatAppearance.BorderSize = 0;
            this.AbfahrtSuchenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AbfahrtSuchenButton.Location = new System.Drawing.Point(395, 55);
            this.AbfahrtSuchenButton.Name = "AbfahrtSuchenButton";
            this.AbfahrtSuchenButton.Size = new System.Drawing.Size(166, 29);
            this.AbfahrtSuchenButton.TabIndex = 8;
            this.AbfahrtSuchenButton.Text = "Verbindung suchen";
            this.AbfahrtSuchenButton.UseVisualStyleBackColor = false;
            this.AbfahrtSuchenButton.Click += new System.EventHandler(this.AbfahrtSuchenButton_Click);
            // 
            // VerbindungssucheAnzeigen
            // 
            this.VerbindungssucheAnzeigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.VerbindungssucheAnzeigen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.VerbindungssucheAnzeigen.FlatAppearance.BorderSize = 0;
            this.VerbindungssucheAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VerbindungssucheAnzeigen.Location = new System.Drawing.Point(3, 142);
            this.VerbindungssucheAnzeigen.Name = "VerbindungssucheAnzeigen";
            this.VerbindungssucheAnzeigen.Size = new System.Drawing.Size(191, 63);
            this.VerbindungssucheAnzeigen.TabIndex = 4;
            this.VerbindungssucheAnzeigen.Text = "Verbindungssuche";
            this.VerbindungssucheAnzeigen.UseVisualStyleBackColor = false;
            this.VerbindungssucheAnzeigen.Click += new System.EventHandler(this.VerbindungssucheAnzeigen_Click);
            // 
            // VerbindungSuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AbfahrtstabellePanel);
            this.Controls.Add(this.VerbindungssucheAnzeigen);
            this.Controls.Add(this.VerbindungsSuchePanel);
            this.Controls.Add(this.AbfahrtstabelleZeigenButton);
            this.Controls.Add(this.Logo);
            this.DoubleBuffered = true;
            this.Name = "VerbindungSuche";
            this.Text = "VerbindungSuche";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungDataGrid)).EndInit();
            this.VerbindungsSuchePanel.ResumeLayout(false);
            this.VerbindungsSuchePanel.PerformLayout();
            this.AbfahrtstabellePanel.ResumeLayout(false);
            this.AbfahrtstabellePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbfahrtstabelleDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label StartStandortLabel;
        private PictureBox pictureBox1;
        private TextBox ZielStandortTextbox;
        private Button VerbindungSuchenButton;
        private Label Logo;
        private Button AbfahrtstabelleZeigenButton;
        private TextBox StartStandortTextbox;
        private DataGridView VerbindungDataGrid;
        private Panel VerbindungsSuchePanel;
        private Button VerbindungssucheAnzeigen;
        private Panel AbfahrtstabellePanel;
        private TextBox AbfahrtstabelleTextbox;
        private DataGridView AbfahrtstabelleDataGrid;
        private Label AbfahrtstabelleLabel;
        private Button AbfahrtSuchenButton;
        private ListBox AutoErgaenzung;
        private ListBox AutoErgaenzungZiel;
        private ListBox AutoErgaenzungAbfahrt;
    }
}