using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayında");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayında");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayında");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayında");
                    break;
                case 5:
                    Console.WriteLine("Mayıs Ayında");
                    break;
                case 6:
                    Console.WriteLine("Haziran Ayında");
                    break;
                case 7:
                    Console.WriteLine("Temmuz Ayında");
                    break;
                case 8:
                    Console.WriteLine("Ağustos Ayında");
                    break;
                case 9:
                    Console.WriteLine("Eylül Ayında");
                    break;
                case 10:
                    Console.WriteLine("Ekim Ayında");
                    break;
                case 11:
                    Console.WriteLine("Kasım Ayında");
                    break;
                case 12:
                    Console.WriteLine("Aralık Ayında");
                    break;
                default:
                    Console.WriteLine("Ay bilgisi bulunamadı tekrar deneyiniz");
                    break;

            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Mevsimimiz Kış");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Mevsimimiz İlkbahar");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Mevsimimiz Yaz");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Mevsimimiz Sonbahar");
                    break;

                //default:
                //    Console.WriteLine("Mevsim bilgisi bulunamıyor....");
                //    break;

            }

            Console.ReadKey();
        }
    }
}
