namespace CCGMailerService.Models.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ccg_WE_tblEmailSettings")]
    public partial class C_ccg_WE_tblEmailSettings
    {
        [Key]
        public long ID { get; set; }

        public string cEmailFrom { get; set; }

        public string cSMTPServer { get; set; }

        public string cUserName { get; set; }

        public string cPassword { get; set; }

        public int iPortNumber { get; set; }

        public int iMailFrequencySeconds { get; set; }
    }
}
