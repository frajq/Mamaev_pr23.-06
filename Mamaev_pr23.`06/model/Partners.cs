//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mamaev_pr23._06.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partners
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partners()
        {
            this.PartnerProduct = new HashSet<PartnerProduct>();
        }
    
        public int IDPartners { get; set; }
        public Nullable<int> IDPartnerType { get; set; }
        public string PartenerName { get; set; }
        public string DirectorName { get; set; }
        public string DirectorSecondName { get; set; }
        public string DirectorLastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string YrAdressPartner { get; set; }
        public string INN { get; set; }
        public int Rate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerProduct> PartnerProduct { get; set; }
        public virtual PartnerType PartnerType { get; set; }
    }
}
