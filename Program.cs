using System.Drawing;
using System.Xml.Linq;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Tural", "Cafarov", "BB102", 91);
            student.GetInfo();
            student.CheckGraduation();
            student.GetDiplomDegree();





        }


    }
}