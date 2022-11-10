using System.ComponentModel;
using Microsoft.VisualBasic.FileIO;

namespace GaragesDemo
{
    internal class CounterDemo
    {
        private List<Person> _people;
        public void Run()
        {
            _people = new List<Person>();
            while (true)
            {
                Console.Clear();
                Show();
                Console.WriteLine("1 - legge til");
                Console.WriteLine("2 - slette");
                Console.WriteLine("3 - tell");
                var cmd = Console.ReadLine();
                if (cmd == "1") Add();
                else if (cmd == "2") Delete();
                else if (cmd == "3") Count();

            }
        }

        private void Count()
        {
            Console.Write("Hvilken indeks vil du telle? ");
            var index = Convert.ToInt32(Console.ReadLine());
            _people[index].Count++;
        }        
        
        private void Delete()
        {
            Console.Write("Hvilken indeks vil du slette? ");
            var index = Convert.ToInt32(Console.ReadLine());
            _people.RemoveAt(index);
        }

        private void Add()
        {
            Console.Write("Navn: ");
            var name = Console.ReadLine();
            _people.Add(new Person(name));
        }

        private void Show()
        {
            foreach (var person in _people)
            {
                Console.WriteLine(person.Name + " " + person.Count);
            }
        }
    }
}
