using System;

namespace basic.atm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bankamatik Uygulaması : Bakiye görüntüleme, Para Çekme, Para Yatırma, Çıkış 


            string secim = "";
            double bakiye = 0;
            double ekHesap = 1000;
            double ekHesapLimiti = 1000;

            do
            {

            Console.Write("1- Bakiye Görüntüleme\n2-Para Yatırma\n3-Para Çekme\n4-Çıkış\nSeçiminiz:");
            secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Bakiyeniz : {0} TL", bakiye);
                        Console.WriteLine("Ek Hesap Bakiyeniz : {0}",ekHesap);
                        break;
                    case "2":
                        Console.WriteLine("Yatırmak istediğiniz tutar: ");
                        double yatirilanTutar = double.Parse(Console.ReadLine());
                        if (ekHesap<ekHesapLimiti)
                        {
                            double ekHesaptanCekilenPara = ekHesapLimiti - ekHesap;
                            if (yatirilanTutar>=ekHesaptanCekilenPara)
                            {
                                ekHesap = ekHesapLimiti;
                                bakiye = yatirilanTutar - ekHesaptanCekilenPara;
                            }
                            else
                            {
                                ekHesap += yatirilanTutar;
                            }
                        }
                        bakiye += yatirilanTutar;
                        break;
                    case "3":
                        Console.WriteLine("Çekmek İstediğiniz tutar ?");
                        double cekilenTutar = double.Parse(Console.ReadLine());
                        if (cekilenTutar>bakiye)
                        {
                            double toplam = bakiye + ekHesap;
                            if (toplam>=cekilenTutar)
                            {
                                Console.WriteLine("Ek Hesaptan Para Çekilsin mi ?");
                                string ekHesapTercihi = Console.ReadLine();
                               
                                if (ekHesapTercihi =="e")
                                {
                                    Console.WriteLine("Paranızı Çekebilirsiniz");
                                    ekHesap -= (cekilenTutar - bakiye);
                                    bakiye = 0;
                                }
                                else
                                {
                                    Console.WriteLine("Bakiye Yetersiz");
                                }
                            }
                            Console.WriteLine("Bakiye Yetersiz");
                        }
                        else
                        {
                            Console.WriteLine("Paranızı Çekebilirsiniz");
                            bakiye -= cekilenTutar;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Çıkış");
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim");
                        break;
                }

            } while (secim != "4");

            Console.WriteLine("Uygulamadan Çıkıldı");
            
        }
    }
}
