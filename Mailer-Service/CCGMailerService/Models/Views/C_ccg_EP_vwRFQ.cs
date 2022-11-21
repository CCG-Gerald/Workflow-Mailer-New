namespace CCGMailerService.Models.Views
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ccg_EP_vwRFQ")]
    public partial class C_ccg_EP_vwRFQ
    {
        [Key]
        public long ID { get; set; }
        public string cRFQNumber { get; set; }
        public long? iRequisitionID { get; set; }
        public long iSupplierID { get; set; }
        public double? fPriceQuotedExcl { get; set; }
        public double? fPriceQuotedTax { get; set; }
        public double? fPriceQuotedIncl { get; set; }
        public double SupplierScore { get; set; }
        public double? fBBBEEScore { get; set; }
        public double? fTotalScore { get; set; }
        public double AveragePercent { get; set; }
        public bool bQuoted { get; set; }
        public bool bFinalPreference { get; set; }
        public bool bPOGenerated { get; set; }
        public bool bSystemPreference { get; set; }
        public DateTime? dQuotationDeadLine { get; set; }
        public int iCreatedBy { get; set; }
        public DateTime? dDateCreated { get; set; }
        public int? iLastModifiedBy { get; set; }
        public DateTime? dDateLastModified { get; set; }
        public DateTime? dReceivedDate { get; set; }
        public DateTime? dExpectedDate { get; set; }
        public DateTime? dEvaluationdate { get; set; }
        public string cEvaluationComments { get; set; }
        public int? iStatusID { get; set; }
        public double fQuotedAmount { get; set; }
        public bool bIsEmailSent { get; set; }
        public int iQValidDays { get; set; }
        public string cNoteToBuyer { get; set; }
        public double fRFQTotalAmount { get; set; }
        public bool bFromPortal { get; set; }
        public bool bQuoteReceived { get; set; }
        public string cStatus { get; set; }
        public int? DCLink { get; set; }
        public string Account { get; set; }
        public string Name { get; set; }
        public string Contact_Person { get; set; }
        public string Physical1 { get; set; }
        public string Physical2 { get; set; }
        public string Physical3 { get; set; }
        public string Physical4 { get; set; }
        public string Physical5 { get; set; }
        public string PhysicalPC { get; set; }
        public string Post1 { get; set; }
        public string Post2 { get; set; }
        public string Post3 { get; set; }
        public string Post4 { get; set; }
        public string Post5 { get; set; }
        public string PostPC { get; set; }
        public string Telephone { get; set; }
        public string Telephone2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Tax_Number { get; set; }
        public string Registration { get; set; }
        public bool? On_Hold { get; set; }
        public string EMail { get; set; }
        public string cSupplierStatus { get; set; }
        public string cRequestNumber { get; set; }
        public string cRequisitionDescription { get; set; }
        public int? iBBBEELevelID { get; set; }
        public bool? bOnlineResponse { get; set; }
        public string cConcealedAmount { get; set; }
        public bool? bIsInvalid { get; set; }
        public string cInvalidReason { get; set; }
        public long? iInvalidReasonID { get; set; }
        public bool? bInCompliant { get; set; }
        public bool? bPublishOnline { get; set; }
        public bool? bAcceptTerms { get; set; }
        public string cTerms { get; set; }
    }
}
