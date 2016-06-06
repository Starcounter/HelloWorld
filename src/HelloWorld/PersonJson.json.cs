using Starcounter;

namespace HelloWorld
{
    partial class PersonJson : Json
    {
        void Handle(Input.SaveTrigger action)
        {
            Transaction.Commit();
        }
    }
}