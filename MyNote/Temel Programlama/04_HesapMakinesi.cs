using System;

namespace 04_HesapMakinesi
{
    public class Program
    {

        enum Islemler
        {

            Toplam,
            Cikarma,
            Carpma,
            Bolme

        }  
        static void Main(string[] args)
        {

            int A = 10;
            int B = 20;

            Islemler secim = (Islemler)0;

            switch(secim)
            {
                case Islemler.Toplam:
                Console.WriteLine($"{A} + {B} = " + (A+B));
                break;
                case Islemler.Cikarma:
                Console.WriteLine($"{A} - {B} = " + (A - B));
                break;
                case Islemler.Carpma:
                Console.WriteLine($"{A} * {B} = " + (A * B));
                break;
                case Islemler.Bolme:
                Console.WriteLine($"{A} / {B} = " + (A / B));
                break;
                default:
                Console.WriteLine("/aGeçersiz Işlem!");
                break;
        }

        Console.Readkey();


        }















    } 
























}