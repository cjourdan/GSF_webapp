using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gsf.TestFwk.Web.Models
{
    public class RecupData
    {
        public Nullable<int> Matricule { get; set; }
        public DateTime RDatDateEntree { get; set; }
        public DateTime RDatDateSortie { get; set; }
        public String RDatMotifEntree { get; set; }
        public String RDatMotifSortie { get; set; }
        public String RDatMotifEntreeLib { get; set; }
        public String RDatMotifSortieLib { get; set; }

        public String Nom { get; set; }
        public String Prenom { get; set; }

        public virtual RecupDossier RecupDossier { get; set; }

    }
}