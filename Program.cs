using System;
using System.Collections.Generic;

namespace forLoobBr
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            TekSayilariGoster();

            CiftSayilariGoster();


            for(int i=0;i<10;i++){
                if(i==4){// 4 ü görünce bırak
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------");

            for(int i=0;i<10;i++){
                if(i==6){ // 6 sayısını görünce atla
                    continue;
                }
                Console.WriteLine(i);
            }
        }


        public static void TekSayilariGoster(){
            Console.WriteLine("Sayi giriniz:");
            int sayi=Convert.ToInt32(Console.ReadLine());
            int ciftToplam=0,tekToplam=0;
            for(int i=0;i<sayi;i++){

                if(i%2==0){
                    ciftToplam+=i;
                    continue;
                }
                Console.WriteLine("TekSayilar:"+i);
                tekToplam+=i;

                
            }

            Console.WriteLine("tekSayiToplamı="+tekToplam+"/CiftSayiToplamı="+ciftToplam);
        }

        public static void CiftSayilariGoster(){
            Console.WriteLine("Sayi giriniz:");
            int sayi=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<sayi;i++){

                if(i%2==0){
                    Console.WriteLine("CiftSayilar:"+i);
                }
                
            }
        }

    }

}