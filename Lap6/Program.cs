using System;


namespace Lap6
{
    class Program
    {
        static void Main(string[] args)
        {
            TraineeStudent su = new TraineeStudent();
            try
            {
                su.StudentID = "Student Name";
                su.Salary = 350f;
                Console.WriteLine("Student name : " + su.StudentID);
                Console.WriteLine("Student GPA  : " + su.Salary);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
    class TraineeStudent
    {
        private string studentID;
        private float salary;
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public float Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 300 && value <= 450)
                    salary = value;
                else
                    throw (new Exception("Error!!!! invalid Salary"));
            }
        }
    }

}
