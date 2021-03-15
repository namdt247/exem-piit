using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.AspNet.Mvc;
using System.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

using Twilio.TwiML;
using Exam_PIIT.Models;

namespace Exam_PIIT.Controllers
{
    public class SendsController : TwilioController
    {
        // GET: Sends
        public ActionResult Index(Account account)
        {
            var accountID = "AC7414643192e79f5503d436169dc3d58b";
            var authToken = "a51be467625006af34026e483a00ece4";
            TwilioClient.Init(accountID, authToken);

            var to = new PhoneNumber(account.Phone);
            var from = new PhoneNumber("+16179967513");

            var message = MessageResource.Create(
                to: to,
                from: from,
                body: "123456"
                );
            return Content(message.Sid);
        }
    }
}