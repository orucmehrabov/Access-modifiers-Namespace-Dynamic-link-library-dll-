using System;

namespace Access_modifiers__Namespace__Dynamic_link_library__dll_
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("163A1", 3);

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
