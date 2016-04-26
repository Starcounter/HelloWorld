using Starcounter;

namespace HelloWorld
{
    partial class PersonJson : Json
    {
        public string FullName => $"{FirstName} {LastName}";

        static PersonJson()
        {
            DefaultTemplate.Expenses.ElementType.InstanceType = typeof(ExpenseJson);
        }

        void Handle(Input.SaveTrigger action)
        {
            Transaction.Commit();
        }

        void Handle(Input.NewExpenseTrigger action)
        {
            new Expense()
            {
                Spender = this.Data as Person,
                Amount = 1
            };
        }
    }
}