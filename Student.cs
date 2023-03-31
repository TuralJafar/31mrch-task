using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        using System;
       using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
    {
        internal class Student
        {
            public string Name;
            public string Surname;
            public string Group;
            public int Point;
            public bool IsGraduated;

            public Student(string name, string surname, string group, int point)
            {
                Name = name;
                Surname = surname;
                Group = group;
                Point = point;


            if (Point > 65)
            {
                IsGraduated = true;
            }
            

            }
            public void GetInfo()
            {
                Console.WriteLine($"Name:{"tural"} ");
                Console.WriteLine($"Surname:{"cafarov"}");
                Console.WriteLine($"Group:{"bb102"}");
                Console.WriteLine($"Point:{"91"}");
                Console.WriteLine($"IsGraduated:{"true"}");

            }
            public void CheckGraduation()
            {
            if (IsGraduated)
            {


                Console.WriteLine("bu telebe mezun olub");
            }

            else
            {
                Console.WriteLine("telebe mezun olmayib");

            }


            }
            public void GetDiplomDegree()
            {
                if (Point < 65)
                {
                    Console.WriteLine("diplom yoxdur");
                }
                else if (Point>65 && Point<80)
                {
                    Console.WriteLine("adi diplom");

                }
                else if (Point>80&&Point<90)
                {
                    Console.WriteLine("sheref diplomu");
                }
                else if (Point > 90)
                {
                    Console.WriteLine("yuksek sheref diplomu");
                }
            }

        }
    }


