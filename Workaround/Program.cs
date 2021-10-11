using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            Vatandas vatandas1 = new Vatandas(); // Vatandaş class ına sahip bir intance(örnek) oluşturduk.
            //Console.WriteLine(vatandas1.DogumYili);
            SelamVer("Arif");
            SelamVer("Emir");
            SelamVer("Mehmet");
            SelamVer();

            int sonuc = Topla(8,9);
            Console.WriteLine("Toplam: {0}",sonuc);
            Console.WriteLine("----------------------------");

            //Arrays

            Console.WriteLine("\nArrays\n");
            String[] ogrenciler = new string[3];
            ogrenciler[0] = "arif";
            ogrenciler[1] = "emir";
            ogrenciler[2] = "mehmet";

            foreach (string ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }

            //List => Yeni projelerde genellikle array lerin yerine kullanılmaktadır.
            //List leri kullanmak için using System.Collections.Generic tanımlaması yapılmalıdır.



            List<string> yeniSehirler = new List<string> { "Ankara", "İstanbul", "İzmir" };
            Console.WriteLine("\nList\n");
            foreach (var yeniSehir in yeniSehirler)
            {
                Console.WriteLine(yeniSehir);
            }

            Person person1 = new Person();
            person1.FirstName = "EMİR EFE";
            person1.LastName = "AKNAR";
            person1.NationalIdentity = 74404071232;
            person1.DateOfBirthYear = 2008;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


        }

        static void SelamVer(string name="Misafir")//Default value
        {
        
            Console.WriteLine("Selam Dostum {0}",name);
        }

        static int Topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public class Vatandas
        {

            public string Name { get; set; }
            public string Surname { get; set; }
            public int Birthday { get; set; }
            public long IdentityId { get; set; }


            //private string name = "arif"; //Private olanlara dışarıdan erişilemez.
            //public string Soyad = "aknar"; //Public olanlara dışarıdan erişim vardır.
            //public  int DogumYili = 1996;
            //public long TcNo = 12345678901;

        }
        private static void Degiskenler()
        {
            string name = "arif";
            string soyad = "aknar";
            int dogumYili = 1996;
            long tcNo = 12345678901;

            Console.WriteLine("Günaydın {0}", name);
        }

       
        
    }


}
