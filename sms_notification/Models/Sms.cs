using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sms_notification.Models
{
    public class Sms
    {
        [Required(ErrorMessage = "Recipient Number Required", AllowEmptyStrings = false)]
        [Phone]
        public string Recipient { get; set; }

        [Required(ErrorMessage = "Sender Number Required", AllowEmptyStrings = false)]
        [Phone]
        public string Sender { get; set; }

        [Required(ErrorMessage = "Message Required", AllowEmptyStrings = false)]
        public string Message { get; set; }
    }
}
