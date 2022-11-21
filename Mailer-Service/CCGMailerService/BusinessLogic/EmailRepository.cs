using CCGMailerService.Models.Tables;
using CCGMailerService.Models.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CCGMailerService.BusinessLogic
{
    public class EmailRepository
    {
        public string emailTo;
        public string emailSubject;
        public string emailOutline;
        public string emailBody;
        public string emailAttachment;
        public string emailBCC;
        public string emailCC;
        public string emailReplyTo;
        public long iRFQID = 0;
        public string connectionString = "";
        public ResponseObject SendEmail()
        {
            ResponseObject response = new ResponseObject();

            try
            {
                SmtpSection smtpSection = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
                using (MailMessage mm = new MailMessage())
                {
                    mm.From = new MailAddress(smtpSection.From, emailOutline);
                    mm.To.Add(emailTo);
                    mm.Subject = emailSubject;
                    mm.Body = emailBody;
                    mm.IsBodyHtml = true;
                    //mm.Bcc.Add(new MailAddress(smtpSection.From));

                    if (emailCC != null && emailCC != "")
                    {
                        mm.CC.Add(new MailAddress(emailCC));
                    }

                    if (emailBCC != null && emailBCC != "")
                    {
                        mm.Bcc.Add(new MailAddress(emailBCC));

                    }
                    if (iRFQID != 0)
                    {
                        mm.ReplyToList.Add(new MailAddress(emailReplyTo));
                    }
                    if (emailAttachment != null && emailAttachment != "")
                    {
                        mm.Attachments.Add(new Attachment(emailAttachment));
                    }
                    if (iRFQID != 0)
                    {
                        using (DatabaseContext db = new DatabaseContext())
                        {
                            db.Database.Connection.ConnectionString = connectionString;

                            C_ccg_EP_vwRFQ rfq = db.C_ccg_EP_vwRFQ.Find(iRFQID);

                            List<C_ccg_EP_tblRFQAdditionalAttachments> listAttachments = db.C_ccg_EP_tblRFQAdditionalAttachments.Where(i => i.iRequisitionID == rfq.iRequisitionID).ToList();

                            foreach (C_ccg_EP_tblRFQAdditionalAttachments attachmentFile in listAttachments)
                            {
                                var fileBytes = attachmentFile.cFileImage;

                                var fileMemStream = new MemoryStream(fileBytes);

                                MemoryStream stream = new MemoryStream(fileBytes);
                                Attachment attachment = new Attachment(stream, attachmentFile.cFileName);

                                mm.Attachments.Add(attachment);
                                //stream.Dispose();
                            }
                        }

                    }

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = smtpSection.Network.Host;
                    smtp.EnableSsl = smtpSection.Network.EnableSsl;

                    ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

                    NetworkCredential networkCred = new NetworkCredential(smtpSection.Network.UserName, smtpSection.Network.Password, smtpSection.Network.ClientDomain);
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = networkCred;

                    smtp.Port = smtpSection.Network.Port;
                    smtp.Send(mm);

                    mm.Dispose();
                    smtp.Dispose();

                    response.Status = ResponseStatus.Success;
                    response.StatusDescription = "Mail to " + emailTo + " sent successfully";
                }
            }

            catch (Exception ex)
            {
                response.Status = ResponseStatus.Exception;
                response.StatusDescription = ex.Message + ex.InnerException;
            }
            return response;
        }
        public ResponseObject SaveEmail()
        {
            string cOutline = System.Configuration.ConfigurationManager.AppSettings["cOutline"];

            ResponseObject response = new ResponseObject();

            try
            {

                if (response.Status == ResponseStatus.Success)
                {
                    using (DatabaseContext db = new DatabaseContext())
                    {
                        db.Database.Connection.ConnectionString = connectionString;

                        C_ccg_WE_tblEmailLog emailLog = new C_ccg_WE_tblEmailLog();

                        emailLog.bMailSent = false;
                        emailLog.cEmailBCC = emailBCC;
                        emailLog.dMailDate = DateTime.Now;
                        emailLog.cSubject = emailSubject;
                        emailLog.cEmailTo = emailTo;
                        emailLog.cEmailBody = emailBody;
                        emailLog.cOutline = cOutline;

                        db.C_ccg_WE_tblEmailLog.Add(emailLog);
                        db.SaveChanges();

                        response.Status = ResponseStatus.Success;
                        response.StatusDescription = "Mail saved successfully.";

                    }
                }
            }
            catch (Exception ex)
            {
                response.Status = ResponseStatus.Failure;
                response.StatusDescription = "Mail could not be saved.";
            }
            return response;
        }
    }
}
