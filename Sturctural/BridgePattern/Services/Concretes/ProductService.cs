using BridgePattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Services.Concretes
{
    public class ProductService : IProductService
    {
        public MessageSenderBase MessageSender { get; set; }
        public ProductService(MessageSenderBase messageSender)
        {
            MessageSender=messageSender;
        }

        public void CreateProduct()
        {
            Console.WriteLine("Ürün oluşturuldu");
            MessageSender.Send();
            MessageSender.SaveToDB();
        }
    }
}
