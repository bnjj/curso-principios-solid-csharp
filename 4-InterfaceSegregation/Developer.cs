namespace InterfaceSegregation
{
    public class Developer : IDeveloperActivities
    {
        public Developer()
        {
        }       
        public void Develop() 
        {
            Console.WriteLine("I'm developing the functionalities required");
        }
    }
}