using System;

namespace AccessModifierNamespaceDll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("163A1", 2);
            Console.WriteLine("Group No: 163A1\n");

            Student student1 = new Student("Oruc", "Mehrabov");
            Student student2 = new Student("Qabil", "Huseynli");
            Student student3 = new Student("Oguzhan", "Maden");

            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.GetStudents();
        }
    }
}
