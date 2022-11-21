namespace CCGMailerService.Models.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ccg_EP_tblRequisition")]
    public partial class C_ccg_EP_tblRequisition
    {
        [Key]
        public long ID { get; set; }
        public long? iRequisitionTypeID { get; set; }
        public long? iWorkflowID { get; set; }
        public DateTime? dCreatedDate { get; set; }
        public int? iCreatedUserID { get; set; }
        public DateTime? dRequisitionDate { get; set; }
        public int? iDepartmentID { get; set; }
        public DateTime? dDeliveryDate { get; set; }
        public string cDeliveryStation { get; set; }
        public string cDescription { get; set; }
        public string cRequestNumber { get; set; }
        public long? iAssignedUserID { get; set; }
        public long? iUnitID { get; set; }
        public long? iSectionID { get; set; }
        public long? iIncidentID { get; set; }
        public int? iPriorityID { get; set; }
        public int? iProjectID { get; set; }
        public int? iStatusID { get; set; }
        public bool? bRequestFor { get; set; }
        public int? iRequestForUserID { get; set; }
        public string cAdditionalNotes { get; set; }
        public long? iStepID { get; set; }
        public long? iProcurementMethodID { get; set; }
        public double? fFunThreshold { get; set; }
        public long? iSupplierID { get; set; }
        public bool? bOnHold { get; set; }
        public bool? bFromRFQApproval { get; set; }
        public string cPONumber { get; set; }
        public long? iContractID { get; set; }
        public bool? bBudgetOverrideHold { get; set; }
        public long? iProcurementCriteriaID { get; set; }
        public bool? bIsAfterRFQ { get; set; }
        public long? iRejectedStepID { get; set; }
        public long? iLoggedByUserID { get; set; }
        public long? iProcurementPlanID { get; set; }
        public bool? bEvaluated { get; set; }
        public bool? bIsMemo { get; set; }
    }
}
