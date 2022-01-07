using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLineTransport
{
    internal class Formatting
    {

        public string ShortenTime(DateTime? dateTime)
        {
            try
            {
                if (dateTime.HasValue)
                {
                    string time = dateTime.Value.ToString();
                    string shortendTime = time.Remove(0, 11);
                    return shortendTime;
                }
                return string.Empty;

            }
            catch { MessageBox.Show("Es wurde kein Wert für die Ankommzeit gefunden.", "ERROR"); }
            return string.Empty;

        }

        public string ShortenDurationTime(string durationTime)
        {
            string time = durationTime.Remove(0, 3);
            time.Remove(time.Length - 4, 3);
            return time;
        }
    }
}
