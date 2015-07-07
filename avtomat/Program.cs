/*
 * Прошу выполнить тестовое задание (код необходимо представить на github):
«Напишите консольное приложение, эмулирующее взаимодействие покупателя с торговым автоматом с печеньками.
Автомат предлагает меню: кексы по 50р 4 шт, печенье по 10р 3 шт и вафли по 30р 10шт.
 * Автомат принимает монеты номиналом 1, 2, 5, 10 рублей.
Покупатель имеет кошелёк, в нём 150р монетами данных номиналов.
Покупатель может вносить в автомат деньги, выбирать пункты меню и просить сдачу.
 * Автомат выдаёт запрошенный предмет, если внесено достаточно денег.
Автомат выдаёт все непотраченные покупателем деньги, если у него запросили сдачу.
Автомат выдаёт сдачу минимальным количеством монет.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtomat
{
    class Program
    {         
        static void Main(string[] args)
        {
            //заполняем кошелек деньгами
            money ks = new money();
            int[] kosh = new int[5];
            kosh = ks.monety(10, 10, 8, 8);
            Console.WriteLine("-------------");
           // Console.WriteLine("В кошельке: " + kosh[4]);
            //


            //заполняем аппарат деньгами
            money avt = new money();
            int[] avtom = new int[5];
            avtom = avt.monety(0, 0, 0, 0);
           // Console.WriteLine("Баланс: " + avtom[4]);
            //
            //кексы
            products ke = new products();
            int[] keks = new int[2];
            keks = ke.tovar(50, 4);
            //печенье
            products pe = new products();
            int[] peche = new int[2];
            peche = pe.tovar(10, 3);
            //вафли
            products va = new products();
            int[] vaf = new int[2];
            vaf = va.tovar(30, 10);

            int i;
            do
            {                    
            Console.WriteLine("Здравствуйте!");
            Console.WriteLine("-------------");
            Console.WriteLine("1 - Кексы    -    50р (" + keks[1] + "шт.)");
            Console.WriteLine("2 - Печенье  -    10р (" + peche[1] + "шт.)");
            Console.WriteLine("3 - Вафли    -    30р (" + vaf[1] + "шт.)");
            Console.WriteLine("-------------");
            Console.WriteLine("4 - Пополнение счета");
            Console.WriteLine("5 - Сдача");
            Console.WriteLine("-------------");
            Console.WriteLine("0 - уйти");
            Console.WriteLine("-------------");
            Console.WriteLine("В кошельке: " + kosh[4]);
            Console.WriteLine("По 1: " + kosh[0] + "; По 2: " + kosh[1] + "; По 5: " + kosh[2] + "; По 10: " + kosh[3]);
            Console.WriteLine("\nБаланс в автомане: " + avtom[4]);
            Console.WriteLine("По 1: " + avtom[0] + "; По 2: " + avtom[1] + "; По 5: " + avtom[2] + "; По 10: " + avtom[3]);
            Console.Write("\nвыбирете поункт меню: ");
                
                //           
                //выбор в меню  
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                        //покупаем кекс
                    case 1:
                        operacii kekeke = new operacii();
                        int[] pk = new int[2];
                        pk = kekeke.pokupka(keks[0], keks[1], avtom[4]);
                        keks = ke.tovar(50, pk[0]);
                        avtom[4] = pk[1];
                        break;
                    //покупаем печенье
                    case 2:
                         operacii pepepe = new operacii();
                        int[] pp = new int[2];
                        pp=  pepepe.pokupka(peche[0], peche[1], avtom[4]);
                        peche = pe.tovar(10, pp[0]);
                        avtom[4] = pp[1];
                            break;
                      
                    //покупаем вафлю
                    case 3:
                         operacii vavava = new operacii();
                         int[] pv = new int[2];
                         pv= vavava.pokupka(vaf[0], vaf[1], avtom[4]);
                         vaf = va.tovar(30, pv[0]);
                         avtom[4] = pv[1];
                        break;

                      //пополнить баланс
                    case 4:
                            Console.WriteLine("1-Кинуть 1 рубль\n2-Кинуть 2 рубля\n3-Кинуть 5 рублей\n4-Кинуть 10 рублей\n0-Выйти");
                            operacii popl = new operacii();
                            int qq;
                            qq = int.Parse(Console.ReadLine());
                            int[] rez = new int[5];
                           rez= popl.oplata(kosh[0], kosh[1], kosh[2], kosh[3], kosh[4], qq);
                           avtom[0] += kosh[0]-  rez[0];
                           avtom[1] += kosh[1] - rez[1];
                           avtom[2] += kosh[2] - rez[2];
                           avtom[3] += kosh[3] - rez[3];
                           avtom[4] += kosh[4]-rez[4];

                           kosh = ks.monety(rez[0], rez[1], rez[2], rez[3]);

                            break;
                        //сдача
                    case 5:
                        operacii sd = new operacii();
                        int[] sda = new int[5];
                        sda =sd.shacha(avtom[4], avtom[0], avtom[1], avtom[2], avtom[3]);
                        kosh[0]+=avtom[0]-sda[0];
                        kosh[1]+=avtom[1]-sda[1];
                        kosh[2]+=avtom[2]-sda[2];
                        kosh[3]+=avtom[3]-sda[3];
                        kosh = ks.monety(kosh[0], kosh[1], kosh[2], kosh[3]);
                        avtom = sda;
                        break;
                    case 0:
                        break;
                }
                Console.Write("\n\n\n\t\t\tНажмите любую клавишу...");
                Console.ReadLine();
                Console.Clear();
            }
            while (i != 0);
            }
        }
    }
 