namespace PropertiesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimePeriod timePeriod = new TimePeriod();
            Console.WriteLine(timePeriod);
            TimePeriod timePeriod1 = new();
            TimePeriod timePeriod2 = new() { Seconds = 360 };
            Console.WriteLine(timePeriod2);
            TimePeriod timePeriod3 = new TimePeriod() { Days = 3 };
            Console.WriteLine(timePeriod3);
            timePeriod3.Days += 5;
            Console.WriteLine(timePeriod3);


            
        }
    }
}