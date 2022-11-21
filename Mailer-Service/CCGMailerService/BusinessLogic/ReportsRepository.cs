using CCGMailerService.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Reporting.Processing;

namespace CCGMailerService.BusinessLogic
{
    public class ReportsRepository
    {
        public string reportTemplatesFolder = "";
        public string generatedReportsFolder = "";
        public string connectionString = "";
        public long iRFQID = 0;

        public string GenerateRFQReport()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Database.Connection.ConnectionString = connectionString;

                C_ccg_EP_vwRFQ existingRFQ = db.C_ccg_EP_vwRFQ.Find(iRFQID);

                var uriReportSource = new Telerik.Reporting.UriReportSource();

                uriReportSource.Parameters.Add(new Telerik.Reporting.Parameter("iRFQID", iRFQID));
                uriReportSource.Parameters.Add(new Telerik.Reporting.Parameter("ConnectionString", connectionString));

                uriReportSource.Uri = reportTemplatesFolder + "RFQ.trdp";

                ReportProcessor reportProcessor = new ReportProcessor();
                RenderingResult result = reportProcessor.RenderReport("PDF", uriReportSource, null);

                string fileName = existingRFQ.cRFQNumber + ".pdf";

                System.IO.File.WriteAllBytes(generatedReportsFolder + fileName, result.DocumentBytes);
                return generatedReportsFolder + fileName;
            }

        }
    }
}
