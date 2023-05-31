using ChainOfResponsibilityPattern.Entities;
using ChainOfResponsibilityPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Services.Concretes
{
    internal class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 100 && expense.Amount<=1000)
                Console.WriteLine("Genel müdür yardımcısı fiyatı onayladı");
            else if (true)
                Successor.HandleExpense(expense);
        }
    }
}
