namespace NorthWindForEntityFramework6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ContactDevice
    {
        public int id { get; set; }

        public int? ContactId { get; set; }

        public int? PhoneTypeIdentifier { get; set; }

        public string PhoneNumber { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual PhoneType PhoneType { get; set; }
    }
}
