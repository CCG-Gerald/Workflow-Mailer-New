using CCGMailerService.Models.Custom;
using CCGMailerService.Models.Tables;
using CCGMailerService.Models.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCGMailerService.BusinessLogic
{
    public class LogicRepository
    {
        public string connectionString = "";
        public string GeneratedReportsFolder = System.Configuration.ConfigurationManager.AppSettings["GeneratedReportsFolder"];
        public string ReportsTemplatesFolder = System.Configuration.ConfigurationManager.AppSettings["ReportsTemplatesFolder"];

        public ResponseObject SendEmail()
        {
            ResponseObject responseObject = new ResponseObject();
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.Database.Connection.ConnectionString = connectionString;

                    C_ccg_EP_tblDefaults defaults = db.C_ccg_EP_tblDefaults.First();

                    List<C_ccg_WE_tblEmailLog> emailList = db.C_ccg_WE_tblEmailLog.Where(m => m.bMailSent == false).ToList();

                    foreach (C_ccg_WE_tblEmailLog emailLog in emailList)
                    {
                        EmailRepository emailRepository = new EmailRepository();

                        emailRepository.emailTo = emailLog.cEmailTo;
                        emailRepository.emailSubject = emailLog.cSubject;
                        emailRepository.emailBody = emailLog.cEmailBody;
                        emailRepository.emailOutline = emailLog.cOutline;
                        emailRepository.emailBCC = emailLog.cEmailBCC;
                        emailRepository.connectionString = connectionString;

                        if (emailLog.iRFQID != null && emailLog.iRFQID != 0)
                        {
                            ReportsRepository reportsRepository = new ReportsRepository();

                            reportsRepository.connectionString = connectionString;
                            reportsRepository.generatedReportsFolder = GeneratedReportsFolder;
                            reportsRepository.reportTemplatesFolder = ReportsTemplatesFolder;
                            reportsRepository.iRFQID = (long)emailLog.iRFQID;

                            var report = reportsRepository.GenerateRFQReport();
                            emailRepository.emailAttachment = report;
                            emailRepository.emailReplyTo = defaults.cRFQReplyToEmail;

                            emailRepository.iRFQID = (long)emailLog.iRFQID;
                        }
                        else
                        {
                            emailRepository.iRFQID = 0;
                        }

                        var response = emailRepository.SendEmail();

                        if (response.Status == ResponseStatus.Success)
                        {
                            UpdateEmailLog(emailLog.ID);
                        }
                        else
                        {
                            if (emailRepository.iRFQID != 0)
                            {
                                C_ccg_WE_tblEmailLog emailErrorLog = new C_ccg_WE_tblEmailLog();
                                emailErrorLog.bMailSent = false;
                                emailErrorLog.cEmailTo = emailRepository.emailBCC;
                                emailErrorLog.cSubject = "Undelivered Mail";
                                emailErrorLog.cOutline = emailLog.cOutline;
                                emailErrorLog.dMailDate = DateTime.Now;
                                emailErrorLog.cEmailBody = "Good day, RFQ Email to " + emailRepository.emailTo + " could not be sent." + response.StatusDescription;

                                db.C_ccg_WE_tblEmailLog.Add(emailErrorLog);
                                db.SaveChanges();
                            }

                        }

                        string[] lines = new string[] { response.StatusDescription + " " + DateTime.Now.ToString() };
                        File.AppendAllLines(@"C:\inetpub\wwwroot\CCG MailerAPI\MailerLog.txt", lines);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return responseObject;
        }

        public void UpdateEmailLog(long ID)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Database.Connection.ConnectionString = connectionString;

                C_ccg_WE_tblEmailLog emailLog = db.C_ccg_WE_tblEmailLog.Find(ID);
                emailLog.bMailSent = true;
                emailLog.dMailDate = DateTime.Now;
                db.SaveChanges();

                if (emailLog.iRFQID != null && emailLog.iRFQID != 0)
                {
                    C_ccg_EP_tblRFQ rfq = db.C_ccg_EP_tblRFQ.Find(emailLog.iRFQID);
                    rfq.bIsEmailSent = true;
                    db.SaveChanges();
                }
            }
        }

        public int ConvertSecondsToMilliseconds()
        {
            int iMilliseconds = 0;

            using(DatabaseContext db = new DatabaseContext())
            {
                db.Database.Connection.ConnectionString = connectionString;

                C_ccg_WE_tblEmailSettings emailSettings = db.C_ccg_WE_tblEmailSettings.First();

                // 1 sec = 1,000 ms
                // milliseconds = seconds × 1,000
                iMilliseconds = emailSettings.iMailFrequencySeconds * 1000;
            }

            return iMilliseconds;
        }
    }
}
