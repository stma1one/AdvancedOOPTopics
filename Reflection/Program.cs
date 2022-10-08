using System.Reflection;

namespace Reflection
{
    internal class Program
    {

        public static void PrintProperties(Object obj)
        {
            //Get the type of the object!
            Type t = obj.GetType();
            Console.WriteLine("Type of object is {0}", t);
            // Get the public properties of the instance (not only related to Object).
            PropertyInfo[] propInfos = t.GetProperties();
            // Display information for all properties.
            for (int i = 0; i < propInfos.Length; i++)
            {
                PropertyInfo propInfo = propInfos[i];
                bool readable = propInfo.CanRead;
                bool writable = propInfo.CanWrite;

                Console.WriteLine("   Property name: {0}", propInfo.Name);
                Console.WriteLine("   Property type: {0}", propInfo.PropertyType);
                Console.WriteLine("   Read:{0}, Write {1}", readable, writable);
                if (readable)
                {
                    Console.WriteLine("   Property value: {0}", propInfo.GetValue(obj));
                }
                Console.WriteLine("*************************************************************************");
            }
        }
        static void Main(string[] args)
        {
            //example of readOnly Property
            //SoccerPlayer player = new() { BirthYear=1980, Goals=0, Name="Kuku"};
            

            SoccerPlayer player = new SoccerPlayer() { BirthYear = 1980, Name = "Kuku" };
            Console.WriteLine($"{nameof(player.Name)}: {player.Name}; {nameof(player.BirthYear)}:{player.BirthYear} {nameof(player.Goals)}:{player.Goals}");
            object p = player;
            Console.WriteLine($" IS {nameof(p)} a Player? ---> {p is Player}");
            Console.WriteLine($" IS {nameof(p)} a SoccerPlayer? ---> {p is SoccerPlayer}");
            Console.WriteLine($" What is the type of {nameof(p)}?  {p.GetType()}");
            Console.WriteLine($"instead of is we can use typeof. p.GetType()==typeof(Player) {p.GetType() == typeof(Player)}");
            Console.WriteLine($"instead of is we can use typeof. p.GetType()==typeof(SoccerPlayer) {p.GetType() == typeof(SoccerPlayer)}");
            #region We can ask about the instance properties in runtime
            PrintProperties(p);
            #endregion
        }
    }
}