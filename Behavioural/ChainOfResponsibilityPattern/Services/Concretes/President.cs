using ChainOfResponsibilityPattern.Entities;
using ChainOfResponsibilityPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Services.Concretes
{
    public class President:ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 1000)
                Console.WriteLine("Genel Müdür fiyatı onayladı");
          
        }
    }
}
