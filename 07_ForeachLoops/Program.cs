using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "Milano", "roma", "budapeşte", "ankara",
            //    "istanbul", "varşova" };

            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}


            //int[] numbers = { 56, 65, 45, 54, 85, 58, 52,852, 9874, 254 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //int[] numbers = { 56, 65, 45, 54, 85, 58, 52,852, 9874, 254 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 56, 65, 45, 54, 85, 58, 52,852, 9874, 254 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //string word = "merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion


            #region Örnek sınav sistemi

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("------------------------------");
            Console.WriteLine("Sınıfınızda Kaç Öğrenci Var : ");
            int studentCount =int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");


            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //her öğrenci için 3 sınav girişi 

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}.sınav notunu giriniz:");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları toluyoruz 
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;

            }
            //sınav ortalaması
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması :{studentExamAvg[i]}");

                //Öğrencinin geçip kalma durumu
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                } 
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
                }
                Console.WriteLine("------------------------------");
            }
            






            #endregion



            Console.Read();
        }
    }
}
