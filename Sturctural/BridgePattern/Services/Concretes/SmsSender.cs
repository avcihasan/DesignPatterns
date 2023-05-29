using BridgePattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Services.Concretes
{
    public class SmsSender : MessageSenderBase
    {
        public override void Send()
        {
            Console.WriteLine("Sms gönderildi");
        }
    }
}
