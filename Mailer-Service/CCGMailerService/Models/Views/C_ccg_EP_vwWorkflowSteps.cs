namespace CCGMailerService.Models.Views
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ccg_EP_vwWorkflowSteps")]
    public partial class C_ccg_EP_vwWorkflowSteps
    {
        [Key]
        public long ID { get; set; }
        public long iStepID { get; set; }
        public long iWorkflowID { get; set; }
        public int iSequenceNumber { get; set; }
        public int? iResponsibleUserID { get; set; }
        public long? iEscalationGroupID { get; set; }
        public int iApprovalMethodID { get; set; }
        public bool bAllowReject { get; set; }
        public bool bAllowCloseAfterReject { get; set; }
        public bool bOnRejectToRaiser { get; set; }
        public long iRejectToStepID { get; set; }
        public long iWorkflowRuleID { get; set; }
        public bool bApplyRule { get; set; }
        public bool bSkipStep { get; set; }
        public long? iThresholdID { get; set; }
        public long? iResponsibleGroupID { get; set; }
        public bool bUseGroup { get; set; }
        public string cAgentName { get; set; }
        public string cDisplayName { get; set; }
        public string cStepDescription { get; set; }
        public string cStepCode { get; set; }
        public string cEscalationName { get; set; }
        public string cResponsibleAgentGroup { get; set; }
        public bool? bUseEscalation { get; set; }
        public bool? bReportLineEscalation { get; set; }
        public long? iEscalationTypeID { get; set; }
        public int? iEscalationTime { get; set; }
        public string cEscalationTypeDesc { get; set; }
        public int? eventID { get; set; }
        public string cEventCode { get; set; }
    }
}
