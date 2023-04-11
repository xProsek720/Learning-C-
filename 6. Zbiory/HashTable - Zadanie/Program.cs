using System.Collections;
namespace HashTable___Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] listaStudenow = new Student[]
            {
                new Student(1, "Kamil", 3.92f),
                new Student(2, "Natalia", 2.92f),
                new Student(3, "Leon", 4.92f),
                new Student(4, "Filip", 4.20f)
            };

            Hashtable studenci = new Hashtable();
            studenci.Add(1, new Student(1, "Marcin", 4.61f));

            foreach (Student student in listaStudenow) 
            {
                if (!studenci.ContainsKey(student.Id))
                {
                    studenci.Add(student.Id, student);
                }
                else 
                {
                    Console.WriteLine($"Student z id: {student.Id} już istnieje!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pora zobaczyć jacy studenci się załadowali: ");

            foreach (Student student in studenci.Values) 
            {
                Console.WriteLine($"ID: {student.Id} | Imie {student.Name} | GPA: {student.GPA}");
            }
            Console.ReadLine();

            
        }
    }
}