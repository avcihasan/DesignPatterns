using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Services.Abstracts
{
    public interface IProductService
    {
        public MessageSenderBase MessageSender { get; set; }
        public void CreateProduct();
    }
}
