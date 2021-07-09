using System;

namespace Metot_Tanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
            //METOT yapısı

            // Erişim belirteci(public, Private, Protected)
            // geridonus_tipi(void ise geri deger donmez)
            // metot_adı(parametrelistesi/arguman)

            
            int a = 2;
            int b = 5;
            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            //**************
            //baska bir klastaki bir metoda erişmek için mutlaka o metodun bir intance si yaratılmalıdır
            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdır(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirveTopla(ref a,ref b);
            ornek.EkranaYazdır(Convert.ToString(sonuc2));
            ornek.EkranaYazdır(Convert.ToString(a+b));
        }

        static int Topla(int deger1, int deger2)
        //static metotlara statik metot içerisinden erişilebilir
        // bu metot bu nedenle static yapıldı
        {
            return(deger1+deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdır(string veri)//farklı claslardan erişim için Public olmalıdır
        {
            Console.WriteLine(veri);
        }

        public int ArttirveTopla(ref int deger1, ref int deger2)
        //metodun parametreleri referans olarak verildiğinde bellekteki yeri verilmiş olur
        //degişkenlerin bellekteki karşıkları üzerinde işlem yapılmış olur, 
        //a ve b nin değeri kalıcı olarak çağırılan fonksiyonda değiştirilmiş olur

        {
            deger1 +=1;
            deger2 +=1;
            return deger1+deger2;
        }
    }
}
