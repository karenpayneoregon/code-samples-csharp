namespace NorthWindForEntityFramework6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessEntityPhone")]
    public partial class BusinessEntityPhone
    {
        public int BusinessEntityPhoneID { get; set; }

        public string PhoneNumber { get; set; }

        public int? PhoneNumberTypeID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedDate { get; set; }
    }
}
