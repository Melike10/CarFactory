using System;
using System.Collections.Generic;

namespace CarFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool devam;
            List<Car> cars = new List<Car>();

            do
            {
                try
                {
                    Console.WriteLine("----- Araba Üretimine Başlıyoruz.-------");

                    Console.Write("Araba Seri No: ");
                    string seriNo = Console.ReadLine();
                    Console.Write("Marka: ");
                    string brand = Console.ReadLine();
                    Console.Write("Model: ");
                    string model = Console.ReadLine();
                    Console.Write("Renk: ");
                    string color = Console.ReadLine();

                ErrorLabel:
                    try
                    {
                        Console.Write("Kapı Sayısı: ");
                        int doorCount = Convert.ToInt32(Console.ReadLine());

                        // Custom exception condition
                        if (doorCount != 2 && doorCount != 4)
                        {
                            throw new InvalidDoorCountException("Kapı sayısı yalnızca 2 veya 4 olabilir.");
                        }

                        Car car = new Car(seriNo, brand, model, color, doorCount);
                        cars.Add(car);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Sayısal değer girmeniz gerekir. Lütfen tekrar deneyiniz.");
                        goto ErrorLabel;
                    }
                    catch (InvalidDoorCountException ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto ErrorLabel;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata oluştu: " + ex.Message);
                }


            control:
                Console.WriteLine("Araba üretimine devam etmek istiyor musunuz?(e/h)");
                string secim = Console.ReadLine().ToLower();

                if (secim == "e")
                    devam = true;
                else if (secim == "h")
                    devam = false;
                else
                {
                    Console.WriteLine("Yanlış veri girdiniz. E ve H girmeniz yeterlidir.");
                    goto control;
                }

            } while (devam);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("*** Üretilen Arabalar***");
            foreach (Car car in cars)
            {
                Console.WriteLine("Seri No :" + car.SerialNum + " / Marka : " + car.Brand);
            }
        }
    }
}
