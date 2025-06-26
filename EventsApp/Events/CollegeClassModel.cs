using System;
using System.Collections.Generic;

namespace Events
{
    public class CollegeClassModel
    {
        public event EventHandler<string> EnrollmentFull;

        private List<string> enrolledStudent = new List<string>();
        private List<string> waitingList = new List<string>();

        public string CourseTitle { get; private set; }
        public int MaximumStudents { get; private set; }

        public CollegeClassModel(string title, int maximumStudents)
        {
            CourseTitle = title;
            MaximumStudents = maximumStudents;
        }

        public string SignUpStudent(string studentName)
        {
            string output = "";
            if (enrolledStudent.Count < MaximumStudents)
            {
                enrolledStudent.Add(studentName);
                output = $"{studentName} was enrolled in {CourseTitle}";

                //Check to see if we are maxed out
                if (enrolledStudent.Count == MaximumStudents)
                {
                    EnrollmentFull?.Invoke(this, $"{CourseTitle} enrollment is now full.");
                }
            }
            else
            {
                waitingList.Add(studentName);
                output = $"{studentName} was added to the wait list for {CourseTitle}";
            }

            return output;
        }
    }
}
