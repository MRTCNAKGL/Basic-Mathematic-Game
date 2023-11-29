using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Oyun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Random rnd = new Random();
      
            int result;
            int answer;
            string replay;
            bool playagain=true;
            int qscount = 0;
            int crrctanswer = 0;
            int wrnganswer = 0;
            int streakcrrct = 0;
            int streakwrng = 0;        
            try
            {
               

                Console.WriteLine("Toplama Oyununa Hoşgeldiniz");
              
                while (playagain)
                {
                   qscount++;
                    int num1 = rnd.Next(1, 101);
                    int num2 = rnd.Next(1, 101);
                    Console.WriteLine(qscount+ $".Soru:{num1}+{num2} kaç eder"); answer = Convert.ToInt16(Console.ReadLine());
                    result = num1 + num2;

                    if (answer != result)
                    {
                        
                        wrnganswer++;
                        streakcrrct=0;
                        streakwrng++;
                        Console.WriteLine("Yanlış Cevap Verdiniz! Doğru cevap :" + result);
                    }
                    else if (answer == result)
                    {
                        streakcrrct++;
                        crrctanswer++;
                        streakwrng = 0;
                        Console.WriteLine($"Doğru Cevap! Cevabınız :{answer} - Tebrikler...");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz Cevap!");
                    }
                    if (streakcrrct == 5)
                    {
                        Console.WriteLine("Tebrikler 5 kere üst üste doğru bildiniz, Oyunu Kazandınız");


                    }
                    if (wrnganswer == 3)
                    {
                        playagain = false;
                        Console.WriteLine("3 kere üst üste yanlış cevap verdiniz. Kaybettiniz!");

                    }

                    Console.WriteLine("Bir daha Oynamak İster Misiniz? (E/H)"); replay = Console.ReadLine().ToUpper();
                    if (replay == "E")
                    {
                       
                        playagain=true;

                    }
                  

                    else 
                    {

                      playagain = false;
                        Console.WriteLine($"Doğru Cevap Sayınız :{crrctanswer}");
                        Console.WriteLine($"Yanlış Cevap Sayınız :{wrnganswer}");
                        Console.WriteLine("İyi Günler!!!");
                        Console.WriteLine("");
                        Console.WriteLine("<Çıkmak için ENTER tuşuna basınız!>");
                        
                        
                      
                    }
                   
                }
               Console.ReadLine();
               
            }
            catch (Exception error)
            {
               
                Console.WriteLine(error.Message);
               
               
            }
           


            Console.ReadLine();

        }
    }
}
