﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetest_2
{
    delegate int calculator (int x, int y);
    
    

        class TestDelegate
        {
            

            public static int Addition(int a, int b)
            {
                num = a+b;
                return num;
            }
             public static int Subtractin(int q, int r)
             {
                num = q - r;
                return num;
             }
           public static int Multiplication(int c, int d)
            {
                num = c*d ;
                return num;
            }
            public static int getNum()
            {
                return num;
            }
            static void Main(string[] args)
            {

                    calculator ak1 = new calculator(Addition);
                    calculator ak2 = new calculator(Subtractin);
                    calculator ak3 = new calculator(Multiplication);

           
                   ak1(16,2);
                   Console.WriteLine("addition value is {0} ", getNum());
                   ak2(2,4);
                   Console.WriteLine("substraction value is {0} ", getNum());
                   ak2(12,2);
                   Console.WriteLine("multiplication value is {0} ", getNum());
                   Console.ReadKey();
            }
        }
  }

