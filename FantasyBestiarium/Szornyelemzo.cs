using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyBestiarium
{
    internal class Szornyelemzo
    {
        private List<Szorny> szornyek;

        public Szornyelemzo(List<Szorny> szornyek)
        {
            this.szornyek = szornyek;
        }

        public int OsszesSzornySzama()
        {
            return szornyek.Count;
        }

        public List<string> VeszelyesSzornyekSzama()
        {
            List<string> szornyekNeve = new List<string>();
            foreach (Szorny szorny in szornyek)
            {
                if (szorny.VeszelyesE)
                {
                    szornyekNeve.Add(szorny.Nev);
                }
            }
            return szornyekNeve;
        }

        public List<string> EgyediElohelyek()
        {
            List<string> elohelyek = new List<string>();
            foreach (Szorny szorny in szornyek)
            {
                if (!elohelyek.Contains(szorny.Elohely))
                {
                    elohelyek.Add(szorny.Elohely);
                }
            }
            return elohelyek;
        }

        public double AtlagosVeszelyesseg()
        {
            double atlag = 0;
            foreach(Szorny szorny in szornyek)
            {
                atlag += szorny.VeszelyessegiSzint;
            }
            return atlag/szornyek.Count;
        }

        public List<Szorny> LegveszelyesebbSzornyek()
        {
            List<Szorny> sz = new List<Szorny>();
            foreach (Szorny szorny in szornyek)
            {
                if (sz.Count == 0 || szorny.VeszelyessegiSzint > sz[0].VeszelyessegiSzint)
                {
                    sz = new List<Szorny>();
                    sz.Add(szorny);
                }
                else if (sz[0].VeszelyessegiSzint == szorny.VeszelyessegiSzint)
                {
                    sz.Add(szorny);
                }
            }
            return sz;
        }

        internal List<Szorny> Szornyek { get => szornyek; }
    }
}
