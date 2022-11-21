using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCGMailerService.Models.Custom
{
    public enum TenderStatuses
    {
        InProgess = 1,
        Invalid,
        Appointed,
        Closed
    }

    public enum RequestStatus
    {
        Saved = 1,
        Request = 2,
        Approved = 3,
        Rejected = 4,
        ApprovedForRFQ = 5,
        SentToSupplier = 6,
        ReceivedQuotation = 7,
        QuatationEvaluation = 8,
        VendorSelect = 9,
        ApprovedForPO = 10,
        ApprovedForStockConsumption = 11,
        RejectedForRFQ = 12,
        Archived = 13,
        ApprovedForTender = 14,
        Closed = 15,
        Invalid = 16
    }

    public enum Actions
    {
        Request = 1,
        Assign = 2,
        Acknowledge = 3,
        Close = 4,
        Escalate = 5,
        ReOpen = 6,
        Approve = 7,
        Reject = 8,
    }

    public enum Level
    {
        Department = 1,
        Unit,
        Section,
        SubSection,
        CFO
    }

    public enum Duration
    {
        Hours = 1,
        Days
    }
}
