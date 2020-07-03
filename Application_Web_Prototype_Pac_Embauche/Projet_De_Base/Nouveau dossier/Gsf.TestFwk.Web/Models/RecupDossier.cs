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
        
        public String RDosNom { get; set; }
        public String RDosPrenom { get; set; }
        public Nullable<int> Matricule { get; set; }
        public String RDosMatriculePres { get; set; }
        public String RDosAge { get; set; }
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
      
    }
    
}