using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sms_notification.Constants;
using sms_notification.Models;
using sms_notification.Response;
using sms_notification.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace sms_notification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMSNotificationController : ControllerBase
    {
        private const string EndpointPrefix = General.apiPrefixName + "sms.";
        private readonly ISMSService _service;
        public SMSNotificationController(ISMSService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> SendSMS(Sms model) => ActionResponse.SuccessOrError(HttpStatusCode.OK,
                 await _service.SendSMS(model),
                $"{EndpointPrefix}notification");
    }
}
