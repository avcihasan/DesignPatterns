using ChainOfResponsibilityPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Services.Abstracts
{
    public abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase Successor;

        public abstract void HandleExpense(Expense expense);

        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            Successor = successor;
        }
    }
}
