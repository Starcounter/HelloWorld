using Starcounter;

namespace HelloWorld
{
    partial class PersonJson : Json
    {
        static PersonJson()
        {
            DefaultTemplate.Expenses.ElementType.InstanceType = typeof(ExpenseJson);
        }

        public string FullName => FirstName + " " + LastName;

        void Handle(Input.SaveTrigger action)
        {
            Transaction.Commit();
        }

        void Handle(Input.CancelTrigger action)
        {
            Transaction.Rollback();
        }

        void Handle(Input.NewExpenseTrigger action)
        {
            new Expense()
            {
                Spender = this.Data as Person,
                Amount = 1
            };
        }

        void Handle(Input.DeleteAllTrigger action)
        {
            Db.SlowSQL("DELETE FROM Expense WHERE Spender = ?", this.Data);
            this.Expenses.Clear();
        }
    }
}