using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Program
    {
        static Student[] studentList;
        static void Main(string[] args)
        {
            //nhap tong so sinh vien
            int numofStudent;
            try
            {
                Console.Write("Num of Student = ");
                numofStudent = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine("Invalid Input Number Of Student! - {0}", ex.Message);
                Console.ReadKey();
                return;
            }
            //Tao danh sach sinh vien
            InputStudentList(numofStudent);
            OutputStudentLitst();
            Console.ReadKey();
        }

        private static void OutputStudentLitst()
        {
            foreach (var student in studentList)
            {
                Console.WriteLine("Student ID ={0}", student.StudentID);
                Console.WriteLine("FullName ={0}", student.FullName);
                Console.WriteLine("Mark ID ={0}", student.Mark);
                Console.WriteLine("Falcuty ID ={0}", student.Falculty);
            }
        }

        /// <summary>
        /// Ham xuat danh sach sinh vien
        /// </summary>

        /// <param name="numofStudent"></param>
        private static void InputStudentList(int numofStudent)
        {
            //Tao mang luu danh sach sinh vien
            studentList = new Student[numofStudent];
            Student student;
            for (int i = 0; i < numofStudent; i++)
            {
                student = new Student();
                Console.Write("Student ID = ");
                student.StudentID = int.Parse(Console.ReadLine());
                Console.Write("FullName = ");
                student.FullName = Console.ReadLine();
                Console.Write("Mark = ");
                student.Mark = float.Parse(Console.ReadLine());
                Console.Write("Falcuty = ");
                student.Falculty = Console.ReadLine();
            }
        }
    }
}
