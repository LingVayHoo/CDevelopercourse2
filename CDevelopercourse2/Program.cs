using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDevelopercourse2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Задание 1
            string fullName = "Гордон Гейбович Фриман";
            byte age = 27;
            string eMail = "gordon.friman@BlackMesa.com";
            string courseName1 = "Программирование";
            float codingScore = 32;
            string courseName2 = "Математика";
            float mathsScore = 67;
            string courseName3 = "Физика";
            float physicsScore = 98;

            Console.WriteLine("Задание 1:\n");
            Console.WriteLine($"    ФИО  {fullName} \nВозраст  {age} \n  eMail  {eMail} \n");
            Console.WriteLine($"\nБаллы по предметам\n");
            Console.WriteLine($"{courseName1,16} {codingScore,5}");
            Console.WriteLine($"{courseName2,16} {mathsScore,5}");
            Console.WriteLine($"{courseName3,16} {physicsScore,5}");
            Console.ReadKey();

            //Задание 2
            float totalScore;
            float averageScore;

            totalScore = codingScore + mathsScore + physicsScore;
            averageScore = totalScore / 3;
            Console.WriteLine("\nЗадание 2:\n");
            Console.WriteLine($"Сумма баллов {totalScore}\nСредний балл {averageScore: #.##}");
            Console.ReadKey();
        }
    }
}
