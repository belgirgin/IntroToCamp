using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = ? (30da kalır)

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999; 
            //sayilar1[0] = ? (cevap 999) 

            //niye ilki 30 kaldı da ikincisi 999 oldu 
            //int, decimal, float, double, boolean = değer tip
            //array, class, interface = referans tip 
            //değer ve referans tipler nasıl çalışır? 
            //bellekte stack ve heap diye iki alan vardır 
            //değer tip olanlar stackte gerçekleşiyor 
            //değer tipte değerleri kopyalar/eşitler işi biter olay sadece değer atamadır
            //int[] sayilar1 yazınca stackte sayilar1 değişkeni tanımlanır
            //new dediğimizde heap'te sayilar1 için alan oluştur der 
            //sayilar2 için de aynısı oluşur 
            //sayilar1=sayilar2;sayilar1'in referans numarası sayilar2'nin referans numarasına eşitlenir
            //artık heapte sadece tek adres ile işlem oluyo 
            //adres kopyalama oluyor 
            //referans tiplerde adresi atamış oluyoruz 
            //sayilar2'nin 0. elemanını 999 yapınca 
            //sayilar1 de aynı adresi tuttuğundan o da 999 olmuş oluyor
            //ilk adresi tutan kalmadı stackte bu yüzden .NET'in garbage collectorü ilk adresi bellekten atar
            //buradan sonra design kolay :) 

        }
    }
}
