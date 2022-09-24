using ToDoIT.Models;

namespace ToDoIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            List<Person> list = new List<Person>();

            id = new Random().Next();
            Person person1 = new Person(id, "Stefan", "Larsson");
            list.Add(person1);

            id = new Random().Next();
            Person person2 = new Person(id, "Lisa", "Karlsson");
            list.Add(person2);

            foreach (Person person in list)
            {
                Console.WriteLine(person.FullName());
            }

        }// End of Main


    }// End of class
}// End of namespace