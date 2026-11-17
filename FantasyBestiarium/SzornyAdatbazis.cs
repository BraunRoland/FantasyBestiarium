using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyBestiarium
{
    internal class SzornyAdatbazis
    {
        private string connectionString;

        public SzornyAdatbazis(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Szorny> Fetolt()
        {
            List<Szorny> szornyek = new List<Szorny>();
            return szornyek;
        }
    }
}
