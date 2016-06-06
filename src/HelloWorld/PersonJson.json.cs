using Starcounter;

namespace HelloWorld
{
    partial class PersonJson : Json
    {
        public string FullName => $"{FirstName} {LastName}";

        void Handle(Input.SaveTrigger action)
        {
            Transaction.Commit();
        }
    }
}