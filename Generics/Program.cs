using Reflection;
namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {4,6,8,10};
           int number= GenericsDemo.Search<int>(arr, 8);
            string[] arr2 = { "4", "kuku", "kaka", "shishlik" };
            string result=GenericsDemo.Search<string>(arr2, "kaka");

            #region Generic Class Usage
            DataCollection<int> dt=new DataCollection<int>();
            dt.Add(number);
            dt.Add(5);
            DataCollection<SoccerPlayer> players=new DataCollection<SoccerPlayer>();
            players.Add(new SoccerPlayer()
            { BirthYear=2000,
             Name="Messi"});
            #endregion
        }
    }
}