#include <stdio.h>
#include <stdlib.h>
#define kalin_cizgi printf("************************************************************\n")
#define ince_cizgi printf("-------------------------------------------------------------\n")
#define baslik printf("*=====* Ogrenci Otomasyon Ders Secim Alanina Hosgeldiniz! *=====*\n\n")

void menu(void){
     system("cls"); baslik;
     printf("\n*|Islem Menusu |*\n-----------------------\n1. D2.En yuksek vize puanini alan ogrenci\n3.En yuksek final puanini alan ogrenci\n4.Final puanina gore sirala\n5.Vize puanina gore sirala\n6.Genel Ortalamaya gore sirala, gecme-kalma durumu\n7.Cikis\n-----------------------\n");
     }

struct tablo{
       char ad[20];
       char soyad[20];
       int vize,final,ortalama;
       };
       typedef struct 
       tablo tablo;
       
       
       int main()
       {
           int s,i,ogr_say,en,pass,gecme,vize_yuzde,final_yuzde,gecen=0,kalan=0;
           FILE *dosya;
           tablo temp,ogrenciler[1000];
          
          
           printf("/===========/ OGRENCI OTOMASYON /===========/\n");
           printf("\nHAZIRLAYAN = Canan ARDIC 0605.02012\n\n");
           printf(" _______  _____                        __\n");
           printf("|       |.-----.-----.-----.----.|__|\n");
           printf("|   -   ||  _  |   _|  -__|     |  __||  |\n");
           printf("|_______||___  |__| |_____|__|__|____||__|\n");
           printf("         |_____|\n");
           printf(" _______ __\n");
           printf("|       |  |_.-----.--------.---.-.-----.--.--.-----.-----.\n");
           printf("|   -   |   _|  _  |        |  _  |__ --|  |  |  _  |     |\n");
           printf("|_______|____|_____|__|__|__|___._|_____|___  |_____|__|__|\n");
           printf("                                        |_____|\n");
           system("color 5f");
           
           if((dosya=fopen("kayit.txt","r+"))==NULL)
           {
           printf("\nHata: Kayit dosyasi mevcut degil.\nLutfen 'kayit.txt' dosyasinin varligini kontrol ediniz.\n");
           system("pause");
           }
           else
           {
           printf("\n**--** Giris Menusu **--**\n1.Yeni giris yapmak icin :\n2.Dosyadaki kayitlari goruntulemek icin :\n3.Islem menusu icin :\n");
           scanf("%d",&s);
           if(s==1){
                    system("cls");
                     baslik;
           printf("Lutfen ogrenci sayisini giriniz: ");
           scanf("%d",&ogr_say);
           
           for(i=0;i<ogr_say;i++){
                                  printf("\n%d . Ogrencinin adi ve soyadi: ",i+1);
                                   fflush( stdin );
                                  scanf("%s%s",&ogrenciler[i].ad,&ogrenciler[i].soyad);
                                  printf("\nVize ve Final notlari: ");
                                  scanf("%d%d",&ogrenciler[i].vize,&ogrenciler[i].final);
                                  fprintf(dosya,"%s %s %d %d\n",ogrenciler[i].ad,ogrenciler[i].soyad,ogrenciler[i].vize,ogrenciler[i].final);
                                  if(i!=ogr_say-1)
                                   printf("\n");
                                  ince_cizgi;
                                  }
           printf("\n<< Giris islemi tamalandi!... >>\n");
           system("pause");
           }
           rewind(dosya);
           i=0;
                    while(!feof(dosya)){
                    fscanf(dosya,"%s%s%d%d",ogrenciler[i].ad,ogrenciler[i].soyad,&ogrenciler[i].vize,&ogrenciler[i].final);
                    i++;}
           ogr_say=i;
           
           if(s==2){
                    system("cls"); baslik;
                    printf("\nSira  %-10s %-20s %-5s %-5s\n\n","Isim","Soyisim","Vize","Final");
                    for(i=0;i<ogr_say;i++){
                    printf("%d .   ",i+1); printf("%-10s %-20s %-5d %-5d\n",ogrenciler[i].ad,ogrenciler[i].soyad,ogrenciler[i].vize,ogrenciler[i].final); ince_cizgi;
                    }
                    system("pause");
                    }
           if(s==3){
           for(1;1;1){ //sonsuz dongu baslangýcý
           menu();
           scanf("%d",&s);
           
           if(s==1){
             en=0;
             system("cls"); baslik;
             for(i=0;i<ogr_say;i++)
             if(ogrenciler[i].vize>ogrenciler[en].vize) en=i;
             kalin_cizgi;
             printf("En yuksek vize puanini alan ogrenci: "); printf("%s %s\n",ogrenciler[en].ad,ogrenciler[en].soyad);
             printf("\nAldigi puan (vize): %d\n",ogrenciler[en].vize);
             kalin_cizgi;
             system("pause");
             }
             
    if(s==2){en=0;
             system("cls"); baslik;
             for(i=0;i<ogr_say;i++)
             if(ogrenciler[i].final>ogrenciler[en].final) en=i;
             kalin_cizgi;
             printf("En yuksek final puanini alan ogrenci: "); printf("%s %s\n",ogrenciler[en].ad,ogrenciler[en].soyad);;
             printf("\nAldigi puan (final): %d\n",ogrenciler[en].final);
             kalin_cizgi;
             system("pause");
             }
                                   
    if(s==3){
             system("cls"); baslik;
             for(pass=1;pass<ogr_say;pass++)
             for(i=0;i<ogr_say-1;i++){
                                      if(ogrenciler[i].final<ogrenciler[i+1].final){
                                                                      temp=ogrenciler[i];
                                                                      ogrenciler[i]=ogrenciler[i+1];
                                                                      ogrenciler[i+1]=temp;
                                                                      }                  
                                      }
             
             printf("\nSira  %-10s %-20s %-5s %-5s\n\n","Isim","Soyisim","Vize","Final");                    
             for(i=0;i<ogr_say;i++){
             printf("%d .   ",i+1);
             printf("%-10s %-20s %-5d %-5d\n",ogrenciler[i].ad,ogrenciler[i].soyad,ogrenciler[i].vize,ogrenciler[i].final); ince_cizgi;}
             system("pause");
             }         
      
    if(s==4){
             system("cls"); baslik;
             for(pass=1;pass<ogr_say;pass++)
             for(i=0;i<ogr_say-1;i++){
                                      if(ogrenciler[i].vize<ogrenciler[i+1].vize){
                                                                      temp=ogrenciler[i];
                                                                      ogrenciler[i]=ogrenciler[i+1];
                                                                      ogrenciler[i+1]=temp;
                                                                      }                                
                                      }
             
             printf("\nSira  %-10s %-20s %-5s %-5s\n\n","Isim","Soyisim","Vize","Final");                    
             for(i=0;i<ogr_say;i++){
             printf("%d .   ",i+1); printf("%-10s %-20s %-5d %-5d\n",ogrenciler[i].ad,ogrenciler[i].soyad,ogrenciler[i].vize,ogrenciler[i].final); ince_cizgi;}
             system("pause");
             }   
             
    if(s==5){
             system("cls"); baslik;
             printf("Lutfen gecme puanini girin: "); scanf("%d",&gecme);
             printf("\nVize yuzdesi: "); scanf("%d",&vize_yuzde);
             printf("\nFinal yuzdesi: "); scanf("%d",&final_yuzde);
             for(i=0;i<ogr_say;i++)
             ogrenciler[i].ortalama=(ogrenciler[i].vize*vize_yuzde+ogrenciler[i].final*final_yuzde)/100;
             
             for(pass=1;pass<ogr_say;pass++)
             for(i=0;i<ogr_say-1;i++){
                                      if(ogrenciler[i].ortalama<ogrenciler[i+1].ortalama){
                                                                                          
                                      temp=ogrenciler[i];
                                      ogrenciler[i]=ogrenciler[i+1];
                                      ogrenciler[i+1]=temp;
                                                                      }                                
                                      }
                                      
             printf("%-10s %-20s %-5s %-5s %-10s %-10s\n\n","Isim","Soyisim","Vize","Final","Ortalama","Sonuc");
             for(i=0;i<ogr_say-1;i++){
             if(ogrenciler[i].ortalama>=gecme){gecen++;
             printf("%-10s %-20s  %-5d %-5d %-10d %-10s\n",ogrenciler[i].ad,ogrenciler[i].soyad,ogrenciler[i].vize,ogrenciler[i].final,ogrenciler[i].ortalama,"GECTi");
             ince_cizgi;
             }
             else{kalan++;
             printf("%-10s %-20s  %-5d %-5d %-10d %-10s\n",ogrenciler[i].ad,ogrenciler[i].soyad,ogrenciler[i].vize,ogrenciler[i].final,ogrenciler[i].ortalama,"KALDI");
             ince_cizgi;
                  }}
                  kalin_cizgi;
             printf("Gecen ogrenci sayisi: %d\nKalan ogrenci sayisi: %d\n",gecen,kalan); 
             kalin_cizgi;
             system("pause");
             }

    if(s==6){ fclose(dosya); return 0;}
             
    }
    }//sonsuz menü döngüsü bitimi
}//if bitim
if(s<1||s>3){ 
              printf("Hatali secim yaptiniz!\n"); system("pause");}

           }
