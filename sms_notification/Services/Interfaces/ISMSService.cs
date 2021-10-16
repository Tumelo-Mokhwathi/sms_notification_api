using CSharpFunctionalExtensions;
using sms_notification.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vonage.Messaging;

namespace sms_notification.Services.Interfaces
{
    public interface ISMSService
    {
        Task<Result<SendSmsResponse>> SendSMS(Sms model);
    }
}
