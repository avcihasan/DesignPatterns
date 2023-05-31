using ObserverPattern.Observers.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Services.Abstracts
{
    public interface IProductService
    {
        void UpdateProduct();
        void Attach(ObserverBase observer);
        void Detach(ObserverBase observer);
    }
}
