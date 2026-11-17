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

        internal List<Szorny> Szornyek { get => szornyek; }
    }
}
