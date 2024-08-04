namespace InterfaceSegregation
{
    public class Tester : ITesterActivities
    {
        public Tester()
        {
        }

        public void Test()
        {
            Console.WriteLine("I'm testing the application");
        }
    }
}