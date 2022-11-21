namespace CCGMailerService.Models.Tables
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ccg_EP_tblDefaults")]
    public partial class C_ccg_EP_tblDefaults
    {
        public long ID { get; set; }

        public bool? bAllowBudgetOverture { get; set; }

        public int? iMinQuotesRequired { get; set; }

        public int? iPONextNum { get; set; }

        public int? iPOPad { get; set; }

        [Required]
        [StringLength(1)]
        public string cPOPadCharacter { get; set; }

        [StringLength(10)]
        public string cPOSuffix { get; set; }

        [StringLength(10)]
        public string cPOPrefix { get; set; }

        public bool? bPOPrefixMonth { get; set; }

        public bool? bPOPrefixYear { get; set; }

        public bool? bAutoGeneratePO { get; set; }

        public int? iPOResetFrequency { get; set; }

        public int? iREQNextNum { get; set; }

        public int? iREQPad { get; set; }

        [Required]
        [StringLength(1)]
        public string cREQPadCharacter { get; set; }

        [StringLength(10)]
        public string cREQSuffix { get; set; }

        [StringLength(10)]
        public string cREQPrefix { get; set; }

        public int? iArchiveDays { get; set; }

        public int? iSupplierOption { get; set; }

        public bool? bEnforceDepartment { get; set; }

        public bool? bEnforceProject { get; set; }

        public bool? bShowRatingTable { get; set; }

        public bool? bMSCOA { get; set; }

        public bool? bConcealQuotePrice { get; set; }

        public bool? bAutoSelectSuppliers { get; set; }

        public int? iNumberOfRFQBidders { get; set; }

        public long? iDefaultCurrencyID { get; set; }

        public bool? bUseWorkflowForRFQPublish { get; set; }

        public int? iRFQPublishWorkflowID { get; set; }

        public int iCreatedBy { get; set; }

        public DateTime? dDateCreated { get; set; }

        public int? iLastModifiedBy { get; set; }

        public DateTime? dDateLastModified { get; set; }

        public int? iMSCID { get; set; }

        public bool? bAllowBackDate { get; set; }

        public int? iMaxAccountCommodities { get; set; }

        public int? iMaxSupplierCommodities { get; set; }

        public double? fCompetitiveValue { get; set; }

        public double? fCFOBidApprovalAmt { get; set; }

        public long? iRFQNextNum { get; set; }

        public int? iRFQPad { get; set; }

        [StringLength(1)]
        public string cRFQPadCharacter { get; set; }

        [StringLength(10)]
        public string cRFQSuffix { get; set; }

        [StringLength(10)]
        public string cRFQPrefix { get; set; }

        public int? iDefaultSupplierTax { get; set; }

        public long? iDevNextNum { get; set; }

        public int? iDevPad { get; set; }

        [StringLength(1)]
        public string cDevPadCharacter { get; set; }

        [StringLength(10)]
        public string cDevSuffix { get; set; }

        [StringLength(10)]
        public string cDevPrefix { get; set; }

        public string cRFQEmail { get; set; }

        public int? iDefaultBuyerID { get; set; }

        public bool? bAllowAutoRequisition { get; set; }

        public long? iTendNextNum { get; set; }

        public int? iTendPad { get; set; }

        [StringLength(1)]
        public string cTendPadCharacter { get; set; }

        [StringLength(10)]
        public string cTendSuffix { get; set; }

        [StringLength(10)]
        public string cTendPrefix { get; set; }

        public string cCommitteeEmail { get; set; }

        public int? iMinBidMembers { get; set; }

        public int? iMaxBidMembers { get; set; }

        public string cAlertCommitteeEmail { get; set; }

        public long? iRequisitionTypeID { get; set; }

        public bool? bAllowSuppOverride { get; set; }

        public bool? bIgnoreStockValidation { get; set; }

        public long? iContactUserID { get; set; }

        public long? iSCMHeadID { get; set; }

        public bool? bAutoArchive { get; set; }

        [StringLength(200)]
        public string cFromEmail { get; set; }

        [StringLength(250)]
        public string cSMTPServer { get; set; }

        public int? iPortNumber { get; set; }

        public string cEmailUserName { get; set; }

        public string cEmailPassword { get; set; }

        public long? iBudgetIncidentTypeID { get; set; }

        [StringLength(250)]
        public string cRFQReplyToEmail { get; set; }

        public bool? bAutoRFQClosingDate { get; set; }

        public int? iRFQClosingDateDays { get; set; }

        public bool? bMandatoryFile { get; set; }

        public bool? bAutoTenderClosingDate { get; set; }

        public int? iTenderClosingDateDays { get; set; }

        public long? iTenderCFOID { get; set; }

        public int? iTenderObjectionDays { get; set; }

        public long? iContractsSpecialistID { get; set; }

        public long? iEnquiryUserID { get; set; }

        public bool? bDefaultContractValue { get; set; }

        public int? iComplianceDays { get; set; }

        public bool? bChangeProcMethod { get; set; }

        public bool? bForceProject { get; set; }

        public int? iProjectTypeID { get; set; }

        public int? iForceTypeID { get; set; }

        public long? iProspectiveWorkflowID { get; set; }

        public bool? bUseSameSCMApprover { get; set; }

        public bool? bBulkDeviations { get; set; }

        public long? iBulkWorkflowID { get; set; }

        public bool? bSplitCriteria { get; set; }

        public bool? bAllowBudgetOverride { get; set; }

        public long? iMemoWorkflowID { get; set; }

        public int? iMemoNextNum { get; set; }

        public int? iMemoPad { get; set; }

        [StringLength(1)]
        public string cMemoPadCharacter { get; set; }

        [StringLength(10)]
        public string cMemoSuffix { get; set; }

        [StringLength(10)]
        public string cMemoPrefix { get; set; }

        public string cRFQTerms { get; set; }
    }
}
