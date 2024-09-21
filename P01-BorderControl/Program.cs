using System.Threading.Channels;

namespace P01_BorderControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Humanoid> humanoid = new List<Humanoid>();
            var data = Console.ReadLine().Split(" ").ToList();
            while (data[0]!="END")
            {
                if (data.Count==3)
                {
                    string name = data[0];
                    string age = data[1];
                    string id = data[2];
                    Humanoid person = new Person(name, age, id);
                    humanoid.Add(person);
                }
                if (data.Count == 2)
                {
                    string model = data[0];
                    string id = data[1];
                    Humanoid robot = new Robot(model, id);
                    humanoid.Add(robot);

                }
                data = Console.ReadLine().Split(" ").ToList();
            }
            string arest = Console.ReadLine();
            foreach (var hid in humanoid)
            {
                string lastThreeDigits = hid.ID.Substring(hid.ID.Length-3,3);
                if (lastThreeDigits == arest)
                {
                    Console.WriteLine(hid.ID);
                }
            }
            
        }
    }
}