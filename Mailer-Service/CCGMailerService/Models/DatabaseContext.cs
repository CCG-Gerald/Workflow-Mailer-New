namespace CCGMailerService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using CCGMailerService.Models.Tables;
    using CCGMailerService.Models.Views;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }
        public virtual DbSet<C_ccg_EP_tblRFQAdditionalAttachments> C_ccg_EP_tblRFQAdditionalAttachments { get; set; }
        public virtual DbSet<C_ccg_WE_tblEmailLog> C_ccg_WE_tblEmailLog { get; set; }
        public virtual DbSet<C_ccg_WE_tblEmailSettings> C_ccg_WE_tblEmailSettings { get; set; }
        public virtual DbSet<C_ccg_EP_vwRFQ> C_ccg_EP_vwRFQ { get; set; }
        public virtual DbSet<C_ccg_EP_tblRFQ> C_ccg_EP_tblRFQ { get; set; }
        public virtual DbSet<C_ccg_EP_tblRequisition> C_ccg_EP_tblRequisition { get; set; }
        public virtual DbSet<C_ccg_EP_vwWorkflowSteps> C_ccg_EP_vwWorkflowSteps { get; set; }
        public virtual DbSet<C_ccg_EP_tblDefaults> C_ccg_EP_tblDefaults { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cPOPadCharacter)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cPOSuffix)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cPOPrefix)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cREQPadCharacter)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cREQSuffix)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cREQPrefix)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cRFQPadCharacter)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cRFQSuffix)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cRFQPrefix)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cDevPadCharacter)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cDevSuffix)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cDevPrefix)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cTendPadCharacter)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cTendSuffix)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cTendPrefix)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cFromEmail)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cSMTPServer)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cEmailUserName)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cEmailPassword)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cRFQReplyToEmail)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cMemoPadCharacter)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cMemoSuffix)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cMemoPrefix)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblDefaults>()
                .Property(e => e.cRFQTerms)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_WE_tblEmailLog>()
                .Property(e => e.cEmailTo)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_WE_tblEmailLog>()
                .Property(e => e.cEmailBody)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_WE_tblEmailLog>()
                .Property(e => e.cSubject)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_WE_tblEmailLog>()
                .Property(e => e.cOutline)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_WE_tblEmailLog>()
                .Property(e => e.cEmailBCC)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_WE_tblEmailSettings>()
                .Property(e => e.cEmailFrom)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_WE_tblEmailSettings>()
                .Property(e => e.cSMTPServer)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_WE_tblEmailSettings>()
                .Property(e => e.cUserName)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_WE_tblEmailSettings>()
                .Property(e => e.cPassword)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblRequisition>()
                .Property(e => e.cDeliveryStation)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblRequisition>()
                .Property(e => e.cDescription)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblRequisition>()
                .Property(e => e.cRequestNumber)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblRequisition>()
                .Property(e => e.cAdditionalNotes)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblRequisition>()
                .Property(e => e.cPONumber)
                .IsUnicode(false);


            modelBuilder.Entity<C_ccg_EP_tblRFQ>()
            .Property(e => e.cRFQNumber)
            .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblRFQ>()
                .Property(e => e.cEvaluationComments)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblRFQ>()
                .Property(e => e.cNoteToBuyer)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwWorkflowSteps>()
               .Property(e => e.cAgentName)
               .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwWorkflowSteps>()
                .Property(e => e.cDisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwWorkflowSteps>()
                .Property(e => e.cStepDescription)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwWorkflowSteps>()
                .Property(e => e.cStepCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwWorkflowSteps>()
                .Property(e => e.cEscalationName)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwWorkflowSteps>()
                .Property(e => e.cEscalationTypeDesc)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwWorkflowSteps>()
                .Property(e => e.cResponsibleAgentGroup)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwWorkflowSteps>()
                .Property(e => e.cEventCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblRFQAdditionalAttachments>()
               .Property(e => e.cFileName)
               .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_tblRFQAdditionalAttachments>()
                .Property(e => e.cFileType)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_WE_tblEmailLog>()
                .Property(e => e.cEmailTo)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_WE_tblEmailLog>()
                .Property(e => e.cEmailBody)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_WE_tblEmailLog>()
                .Property(e => e.cSubject)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_WE_tblEmailLog>()
                .Property(e => e.cOutline)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
               .Property(e => e.cRFQNumber)
               .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.cEvaluationComments)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.cNoteToBuyer)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.cStatus)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Contact_Person)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Physical1)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Physical2)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Physical3)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Physical4)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Physical5)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.PhysicalPC)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Post1)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Post2)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Post3)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Post4)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Post5)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.PostPC)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Telephone2)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Fax1)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Fax2)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Tax_Number)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.Registration)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.cSupplierStatus)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.cRequestNumber)
                .IsUnicode(false);

            modelBuilder.Entity<C_ccg_EP_vwRFQ>()
                .Property(e => e.cRequisitionDescription)
                .IsUnicode(false);
        }
    }
}
