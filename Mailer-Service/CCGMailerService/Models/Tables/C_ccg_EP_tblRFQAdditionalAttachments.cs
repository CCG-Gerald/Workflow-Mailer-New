namespace CCGMailerService.Models.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ccg_EP_tblRFQAdditionalAttachments")]
    public partial class C_ccg_EP_tblRFQAdditionalAttachments
    {
        [Key]
        public long ID { get; set; }

        public long iRequisitionID { get; set; }

        public string cFileName { get; set; }

        public string cFileType { get; set; }

        public byte[] cFileImage { get; set; }
        public string cFileDescription { get; set; }
        public long? iFileCategoryID { get; set; }
        public long? iCreatedByID { get; set; }
        public DateTime dCreatedDate { get; set; }
    }
}
