//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AN.Core.Domain
{
    using AN.Core.Data;
    using System.Collections.Generic;

    public partial class Expertise : BaseEntity
    {
        public Expertise()
        {
            this.DoctorExpertises = new HashSet<DoctorExpertise>();
        }
                  
        public string Name { get; set; }
        public string Name_Ku { get; set; }        
        public string Name_Ar { get; set; }
       
        public string Description { get; set; }        
        public string Description_Ku { get; set; }        
        public string Description_Ar { get; set; }

        public int ExpertiseCategoryId { get; set; }       
      
        public virtual ExpertiseCategory ExpertiseCategory { get; set; }

        public virtual ICollection<DoctorExpertise> DoctorExpertises { get; set; }
    }
}
