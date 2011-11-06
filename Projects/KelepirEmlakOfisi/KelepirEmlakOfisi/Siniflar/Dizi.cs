using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace KelepirEmlakOfisi.Siniflar
{
    class Dizi
    {
        public string dosyayolu;
        public bool hataDurumu = false;
        StreamReader sr;
        StreamWriter sw;

        public ArrayList sehirdoldur()
        {
           ArrayList sehirlistesi=new ArrayList(); //sehirlistesi için dizi tanımladım
            sr = new StreamReader(dosyayolu + @"\VeriKaynakları\SEHIRLER.txt", Encoding.Default); //türkçe kaarkterlerin sorunsuz gelmesi için encodin yaptım KARAKTER AYIR DEMEK İŞLETİM SİSTEMİNİN KARAKTERİNİ TANIYO
            sehirlistesi.Add("Seçiniz"); //direk datasource'un içinde ekleyip listede çıkartabilirsin.
            while (sr.Peek() != -1) // dosya içnde akyıt okunabildiği sürece döngü çalışabilsin. kayıt okunduu sürece -1 den fakrlı bir değer gelir.eofta -1 üretir.
            {
                string satir=sr.ReadLine(); // herbir satır okunsun ve tüm satır değikene atansın
                sehirlistesi.Add(satir.Split('@')[1]); // satır @ ayıracından ayır ve ayrılmış parçalardan indexi 1 olan arraye ekle 
            }
            sr.Close(); // stream iişi bitti bellekleti bilgileri aktar
            return sehirlistesi; // hazır olan array i methodun çağırıldığı yre gönder
        }
        
        public ArrayList semtdoldur(int sehirID)
        {
            ArrayList semtlistesi = new ArrayList(); //semtlistesi için dizi tanımladım
            sr = new StreamReader(dosyayolu + @"\VeriKaynakları\SEMTLER.txt", Encoding.Default); //türkçe kaarkterlerin sorunsuz gelmesi için encodin yaptım KARAKTER AYIR DEMEK İŞLETİM SİSTEMİNİN KARAKTERİNİ TANIYO
            semtlistesi.Add("Seçiniz"); //direk datasource'un içinde ekleyip listede çıkartabilirsin.
            while (sr.Peek() != -1) // dosya içnde kayıt okunabildiği sürece döngü çalışabilsin. kayıt okunduu sürece -1 den fakrlı bir değer gelir.eofta -1 üretir.
            {
                string satir = sr.ReadLine(); // herbir satır okunsun ve tüm satır değikene atansın

                if (int.Parse(satir.Split('@')[1]) == sehirID)
                {
                    semtlistesi.Add(satir.Split('@')[2]);
                }
            }

            sr.Close(); // stream iişi bitti bellekleti bilgileri aktar
            return semtlistesi; // hazır olan array i methodun çağırıldığı yre gönder
        }

        public int SehirIDGetir(string seciliSehir)
        {
            // dosyayı oku belleğe al
            sr = new StreamReader(dosyayolu + @"\VeriKaynakları\SEHIRLER.txt", Encoding.Default);
            int sonuc = 0; // sonuc degiskeni bize sehirID'i dondurucek

            while (sr.Peek() != -1) // dosya bitene kadar tara
            {
                string satir = sr.ReadLine(); // satir oku satir degiskenine ata
                int sehirID = int.Parse(satir.Split('@')[0]); //okunan satiri @'den onceki karakteri sehirIDsini al
                string sehir = satir.Split('@')[1]; //okunan satiri @'den sonraki karakteri sehrin adını al

                if (sehir == seciliSehir) //metoda gonderilen sehir ile dosyadan okunan sehri karsilastir
                {
                    sonuc = sehirID; //if karsilastirması dogruysa o sehrin IDsini sonuca esitle.
                    break;
                }
            }
            sr.Close();
            return sonuc;
        }

        public void MusteriKaydet(string adSoyad, string telefon, string sehir, string semt, string adres)
        {
            try
            {
                string dosya = System.Configuration.ConfigurationSettings.AppSettings["KullaniciDB"];
                sw = new StreamWriter(dosya, true, Encoding.Default);
                System.Text.StringBuilder strbld = new StringBuilder(adSoyad);
                strbld.Append("@");
                strbld.Append(telefon);
                strbld.Append("@");
                strbld.Append(sehir);
                strbld.Append("@");
                strbld.Append(semt);
                strbld.Append("@");
                strbld.Append(adres);
                sw.WriteLine(strbld.ToString());
            }
            catch (Exception)
            {
                hataDurumu = true;
            }

            finally
            {
                sw.Close();
            }
        }

        public int musteriSay()
        {  
            int musteriSayisi = 0;
            string dosya = System.Configuration.ConfigurationSettings.AppSettings["KullaniciDB"];
            sr = new StreamReader(dosya, Encoding.Default);

            while (sr.Peek() != -1)
            {
                sr.ReadLine();
                musteriSayisi += 1;
            }

            sr.Close();
            return musteriSayisi;
        }
    }
 }