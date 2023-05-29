using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Services.Abstracts
{
    public abstract class MessageSenderBase
    {
        public void SaveToDB()
        {
            Console.WriteLine("Veri tabanına kayıt edildi");
        }

        public abstract void Send();
    }
}
