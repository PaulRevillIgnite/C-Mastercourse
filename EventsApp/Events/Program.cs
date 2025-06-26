using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollegeClassModel history = new CollegeClassModel("History", 3);
            CollegeClassModel math = new CollegeClassModel("Maths", 2);

            history.EnrollmentFull += CollegeClass_EnrollmentFull;

            history.SignUpStudent("Paul Revill").PrintToConsole();
            history.SignUpStudent("Coral Murphy").PrintToConsole();
            history.SignUpStudent("Joe Burns").PrintToConsole();
            history.SignUpStudent("Astro Dog").PrintToConsole();
            history.SignUpStudent("Mike Dean").PrintToConsole();

            Console.WriteLine();

            math.EnrollmentFull += CollegeClass_EnrollmentFull;

            math.SignUpStudent("Paul Revill").PrintToConsole();
            math.SignUpStudent("Coral Murphy").PrintToConsole();
            math.SignUpStudent("Joe Burns").PrintToConsole();

            Console.ReadLine();
        }

        private static void CollegeClass_EnrollmentFull(object sender, string e)
        {
            CollegeClassModel model = (CollegeClassModel)sender;

            Console.WriteLine();
            //Console.WriteLine(e);
            Console.WriteLine($"{model.CourseTitle}: Full");
            Console.WriteLine();
        }
    }
}
