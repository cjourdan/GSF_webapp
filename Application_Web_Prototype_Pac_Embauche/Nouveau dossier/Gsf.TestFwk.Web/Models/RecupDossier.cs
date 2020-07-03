using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gsf.TestFwk.Web.Models
{
    public class RecupDossier
    {
        public RecupDossier()
        {
            this.Datas = new HashSet<RecupData>();
        }

        public RecupDossier(SampleEntities entities)
        {
            this.entities = entities;
        }

        private SampleEntities entities;

        public String RDosNom { get; set; }
        public String RDosPrenom { get; set; }
        public Nullable<int> Matricule { get; set; }
        public String RDosMatriculePres { get; set; }
        public Nullable<int> RDosAge { get; set; }
        public DateTime RDosDateEntreeSoc { get; set; }
        public String RDosNumSS { get; set; }

        public DateTime RDosDateEntree { get; set; }
        public DateTime RDosDateSortie { get; set; }
        public String RDosMotifEntree { get; set; }
        public String RDosMotifSortie { get; set; }
        public String RDosMotifEntreeLib { get; set; }
        public String RDosMotifSortieLib { get; set; }

        public DateTime RDosDateDebAF { get; set; }
        public DateTime RDosDateFinAF { get; set; }
        public String RDosEmploiAF { get; set; }
        public String RDosEmploiLibAF { get; set; }

        public virtual ICollection<RecupData> Datas { get; set; }

        public String RDosSexe { get; set; }
        public String RDosNomNaiss { get; set; }
        public String RDosVilleNaiss { get; set; }
        public DateTime RDosDateNaiss { get; set; }
        public String RDosNationalite { get; set; }
        //public String RDosEmail { get; set; }
        public String RDosSitFAm { get; set; }
        public Nullable<int> RDosNbKids { get; set; }
        public Nullable<int> RDosNbPersCharge { get; set; }
        public String RDosAdresse { get; set; }
    }

}