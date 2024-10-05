using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            /*
            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("--- Elma birim Fiyatı:" + applePrice + " TL");
            Console.WriteLine("--- Portakal birim Fiyatı:" + orangePrice + " TL");
            Console.WriteLine("--- Çilek birim Fiyatı:" + strawberryPrice + " TL");
            Console.WriteLine("--- Patates birim Fiyatı:" + potatoPrice + " TL");
            Console.WriteLine("--- Domates birim Fiyatı:" + tomatoPrice + " TL");
            Console.WriteLine();
            Console.WriteLine();
            double appleGram, orangeGram, strawberyGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberyGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawTotalPrice = strawberyGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;


            Console.WriteLine("Alınan ürün: Elma - " + "Birim Fiyat:" + applePrice + " - Gramaj:" + appleGram + "Toplam Tutar:" + appleTotalPrice);
            Console.WriteLine("Alınan ürün: Portakal - " + "Birim Fiyat:" + orangePrice + " - Gramaj:" + orangeGram + "Toplam Tutar:" + orangeTotalPrice);
            Console.WriteLine("Alınan ürün: Çilek - " + "Birim Fiyat:" + strawberryPrice + " - Gramaj:" + strawberyGram + "Toplam Tutar:" + strawTotalPrice);
            Console.WriteLine("Alınan ürün: Patates - " + "Birim Fiyat:" + potatoPrice + " - Gramaj:" + potatoGram + "Toplam Tutar:" + potatoTotalPrice);
            Console.WriteLine("Alınan ürün: Domates - " + "Birim Fiyat:" + tomatoPrice + " - Gramaj:" + tomatoGram + "Toplam Tutar:" + tomatoTotalPrice);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            double ShoppingTotalPrice = appleTotalPrice + orangeTotalPrice +
                strawTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine("Alışverişin Toplam Tutarı: " + ShoppingTotalPrice + " TL");
           */
            #endregion

            #region Char değişkenler

            //char symbol;
            //symbol = 'a'; 
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String
            /*
            Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi*****");
            Console.WriteLine();

            string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge,
                passangerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passangerName = Console.ReadLine();

            Console.Write("Yolcu soyadı:");
            passangerSurname = Console.ReadLine();
            
            Console.Write("İlçe Bilgisi: ");
            passangerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: ");
            passangerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş: ");
            passangerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No: ");
            passangerIdentityNumber = Console.ReadLine();


            Console.WriteLine("-----------------------------");
            Console.WriteLine("Yolcu TC Kimlik No: " + passangerIdentityNumber + " - Yolcu Ad Soyad: " + passangerName + " " +
                passangerSurname + " " + passangerDistrict + " / " + passangerCity + " " + passangerAge);
            */

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri
            /*
            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız Televizyon sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());


            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice +
                chairCount * chairPrice + tvCount * tvPrice;

            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);
            */
            #endregion

            #region Klavyeden Ondalıklı sayı İşlemleri
            /*
            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1.sınav Notu giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2.sınav Notu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3.sınav Notu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.Write("Sınav Ortalamanız:  " + result);
            */

            #endregion

            #region Klavyeden Karakter Girişleri
            /*
            char gender;
            Console.WriteLine("Lütfen Cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            */
            #endregion





            Console.Read();
        }
    }
}
