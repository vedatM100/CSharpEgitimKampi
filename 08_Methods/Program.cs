using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //()
            //geriye değer döndürmeyen metotlar
            //Customer---> Listele, ekle, sil, güncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();


            //void Sum()
            //{
            //    int x = 1; 
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();


            #endregion


            #region Geriye Değer döndürmeyen Parametreli Metotlar

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine();
            //}
            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("müsteri: " + name+ " " + surName);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion


            #region Geriye Değer döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1,  int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4,5,6);

            #endregion


            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yılmaz";
            //}
            //CustomerName();


            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentCard());
            #endregion


            #region Geriye Değer Döndüren Parametreli Metotlar

            //string CoutryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " +
            //        capital + " - Bayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CoutryCard(x, y, z));
            //Console.WriteLine(CoutryCard("Türkiye" , "Ankara", "Kırmızı - Beyaz"));


            #endregion


            #region geriye değer döndüren int Parametreli Metotlar

            //int Sum(int number1 ,  int number2)
            //{
            //    int result =  number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 96));
            //Console.WriteLine(Sum(54, 85));
            //Console.WriteLine(Sum(25, 85));
            //Console.WriteLine(Sum(96, 47));

            #endregion


            #region Örnek Uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci Sınavı Geçti " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci Sınavı geçemedi " + "Ortalama: " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali", 25, 45, 55));
            //Console.WriteLine(ExamResult("Ayşe", 36, 45, 78));


            #endregion


            Console.Read();
        }
    }
}
