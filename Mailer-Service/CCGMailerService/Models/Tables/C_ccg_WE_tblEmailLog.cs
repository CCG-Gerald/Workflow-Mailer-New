namespace CCGMailerService.Models.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ccg_WE_tblEmailLog")]
    public partial class C_ccg_WE_tblEmailLog
    {
        public long ID { get; set; }

        [Required]
        [StringLength(250)]
        public string cEmailTo { get; set; }

        [Required]
        public string cEmailBody { get; set; }

        [Required]
        [StringLength(250)]
        public string cSubject { get; set; }

        [Required]
        [StringLength(250)]
        public string cOutline { get; set; }

        [StringLength(250)]
        public string cEmailBCC { get; set; }

        public bool bMailSent { get; set; }

        public DateTime dMailDate { get; set; }

        public DateTime dMailCreatedDate { get; set; }

        public long? iRFQID { get; set; }

        public Guid cModuleGUID { get; set; }
    }
}
