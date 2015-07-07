using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtomat
{
    class operacii
    {
        public int[] pokupka(int a, int b, int c) // a,b - цена и количество товара; c - баланс
        {
            
            products qq = new products();
            int[] pr = new int[2];
            pr = qq.tovar(a, b);
            if (pr[1] > 0)      //проверяем, есть ли товар в наличии
            {
                if (pr[0] <= c) //проверяем, хватит ли денег
                {
                    pr[1]--;
                    c -= pr[0];
                    Console.WriteLine("Возьмите ваш товар\nтовара осталось: "+pr[1]+"\nденег осталось: "+c);
                }
                else { Console.WriteLine("Извините, у вас недостаточно средств"); };
            }
            else { Console.WriteLine("Извините, товара нет в наличии"); };
            int[] pok = new int[2];
            pok[0] = pr[1];
            pok[1] = c;
            return pok; //кол. товара и баланс
        }

        public int[] shacha(int d, int q1, int q2, int q3, int q4) //количество остатка 
        {                                                          //количество  монет в автомате
            int[] sd = new int[5];
            sd[4] = d;  //баланс
            sd[0] = q1; //кол. монет по 1
            sd[1] = q2; //           по 2
            sd[2] = q3; //           по 5
            sd[3] = q4; //           по 10

            if (sd[4] > 0)
            {
                if (sd[3] > 0)
                {
                    int w = sd[4] / 10;
                    if (w > 0)
                    {
                        Console.WriteLine(w + "монет(ы) по 10 рублей");
                        sd[4] -= w * 10;
                        sd[3] -= w;
                    }
                }
                //сдача монетами по 5
                if (sd[3] > 0)
                {
                    int w = sd[4] / 5;
                    if (w > 0)
                    {
                        Console.WriteLine(w + "монет(ы) по 5 рублей");
                        sd[4] -= w * 5;
                        sd[2] -= w;
                    }
                }
                //сдача монетами по 2
                if (sd[1] > 0)
                {
                    int w = sd[4] / 2;
                    if (w > 0)
                    {
                        Console.WriteLine(w + "монет(ы) по 2 рубля");
                        sd[4] -= w * 2;
                        sd[1] -= w;
                    }
                }
                //сдача монетами по 1
                if (sd[0] > 0)
                {
                    int w = sd[4];
                    if (w > 0)
                    if (sd[4] > 0)
                    {
                        Console.WriteLine(sd[0] + "монет(ы) по 1 рублю");
                        sd[4] -= w;
                        sd[0] -=w;
                    }
                }
               
            }
            else { Console.WriteLine("Баланс равен 0"); };
            return sd;
        }

        //oplata
        public int[] oplata(int a, int b, int c, int d, int e, int f) //1,2,5,10, sum
        {
            int[] opl = new int[5];
           // opl[5]=f;
            if (f == 1 || f == 2 || f == 3 || f == 4 || f == 0)
            {
                //монетка в 1
                if (f == 1)
                {
                    if (a > 0)
                    {
                        a--;
                        e--;
                        Console.WriteLine("монета принята");
                    }
                    else { Console.WriteLine("у вас нет монет по 1 рублю"); };
                }
                //монетка в 2
                if (f == 2)
                {
                    if (b > 0)
                    {
                        b--;
                        e -= 2;
                        Console.WriteLine("монета принята");
                    }
                    else { Console.WriteLine("у вас нет монет по 2 рубля"); };
                }
                //монетка в 5
                if (f == 3)
                {
                    if (c > 0)
                    {
                        c--;
                        e -= 5;
                        Console.WriteLine("монета принята");
                    }
                    else { Console.WriteLine("у вас нет монет по 5 рублей"); };
                }
                //монетка в 10
                if (f == 4)
                {
                    if (d > 0)
                    {
                        d--;
                        e -= 10;
                        Console.WriteLine("монета принята");
                    }
                    else { Console.WriteLine("у вас нет монет по 10 рублей"); };
                }
                
            }
            else { Console.WriteLine("Выбирайте только из меню, пожалуйста"); };

            opl[0]=a;
            opl[1]=b;
            opl[2]=c;
            opl[3]=d;
            opl[4]=e;
            return opl;
        }
    }
}