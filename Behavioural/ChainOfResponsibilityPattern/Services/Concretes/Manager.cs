using ChainOfResponsibilityPattern.Entities;
using ChainOfResponsibilityPattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Services.Concretes
{
    public class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount <= 100)
                Console.WriteLine("Müdür fiyatı onayladı");
            else if (true)
                Successor.HandleExpense(expense);
        }
    }
}
