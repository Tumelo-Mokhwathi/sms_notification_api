using CSharpFunctionalExtensions;
using Microsoft.Extensions.Options;
using sms_notification.Configurations;
using sms_notification.Models;
using sms_notification.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vonage.Messaging;
using Vonage.Request;

namespace sms_notification.Services.Implementations
{
    public class SMSService : ISMSService
    {
        private readonly SMSOptions _options;
        public SMSService(IOptions<SMSOptions> option)
        {
            _options = option.Value;
        }
        public async Task<Result<SendSmsResponse>> SendSMS(Sms model)
        {
            var credentials = Credentials.FromApiKeyAndSecret(_options.Key, _options.Secret);
            var client = new SmsClient(credentials);
            var request = new SendSmsRequest { 
                To = model.Recipient, 
                From = model.Sender, 
                Text = model.Message 
            };

            var response = await client.SendAnSmsAsync(request).ConfigureAwait(false);

            return Result.Success(response);
        }
    }
}
