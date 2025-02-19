namespace Sube2.MetodlarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Benim Yaptığım 2. Hafta
            //Console.Write("Toplanacak ilk sayıyı giriniz= ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());   
            //Console.Write("Toplanacak ikinci sayıyı giriniz= ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Topla(sayi1, sayi2).ToString());
            #endregion
            #region Hocanın Yaptığı 2. Hafta
            //Console.WriteLine("Sayı giriniz: ");
            //int sayi1 = int.Parse(Console.ReadLine()); 
            //Console.WriteLine("Bir sayı daha giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(Topla(sayi1,sayi2));
            #endregion
            //Console.Write("İlk sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Hangi işlemi istiyorsunuz \n Toplama (t) / Çıkarma (c): ");
            //string islem = Console.ReadLine();
            //switch (islem.Trim())
            //{
            //    case "t":
            //      Console.WriteLine(Topla(sayi1, sayi2));
            //        break;
            //    case "c":
            //        Console.WriteLine(Cikar(sayi1, sayi2));
            //        break;
            //    default:
            //        Console.WriteLine("Yanlış Seçim Yaptınız!!");
            //        break;
            //}

            Console.Write("Kaç adet sayı toplamak istiyorsunu?: ");
            int adet = int.Parse(Console.ReadLine());
            int[] sayilar = new int[adet];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write($"{i + 1}. Sayıyı giriniz: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Girdiğiniz {adet} adet sayının toplamı = {Topla(sayilar)}");



        }


        static int Topla(int s1, int s2)//Metot parametreyle tanımlanmak istiyorsa parantez içine tanımlanmalı (Burada 2 tane parametre kullandık)
        {
            int sonuc = s1 + s2;
            return sonuc;//geri dönüşü gerçekleştirmek, methottan çıkmaya yarar
        }

        static int Topla(int s1, int s2, int s3)//int, int, int Metod İmzası
        {
            int sonuc = s1 + s2 + s3;
            return sonuc;
        }

        static int Cikar(int s1, int s2)
        {
            int sonuc = s1 - s2;
            return sonuc;
        }
        static int Topla(int[] sayilar)
        {
            int sonuc = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                sonuc += sayilar[i];
            }
            return sonuc;
        }

    }
}

/*

|| 2. Hafta ||
Parametre: Nasıl iş yapılması gerektiğini tanımlarız
Method Overloading (Metotların Aşırı Yüklenmesi): Metot imzaları farklı olursa, aynı isimle metdlar tanımlanabilir. Bu metodun işlevselliğini arttırır
Metod içine başka bir metod tanımlaması yapılmaz
Metod tanımlamalarının sonunda ; olmaz
İçerisinde tek satır işlem olan metodlarda gövde tanımlaması yerine => (lambda) operatörü kullanılabilir.
örnek lamda kullanımı: "static int Cikar(int s1, int s2)=>s1-s2;" şeklindeki kullanım
return ifadesi ile metodlar değer dönüü yaparlar. Bu değerler metodların çağrıldğı yere döndürülür.
Debug işlemlerinde Metod içerisinde ilerlemek için F11 kullanılır
Void olarak tanımlanan metodlar geri dönüş yapmazlar, dolayısıyla return kullanılmasına gerek yoktur. Kullanılırsa da return; şeklinde kullanılabilir ve metoddan çıkış anlamına gelir.


 */
