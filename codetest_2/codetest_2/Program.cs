using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetest_2
{
    delegate int calculator (int x, int y);
    
    

        class TestDelegate
        {
            
              static int num = 10;
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
                   ak2(5,2);
                   Console.WriteLine("multiplication value is {0} ", getNum());
                   Console.ReadKey();
            }
        }
  }
2.
select DATEDIFF(dd,'2011/05/12','2021/2/9') AS DateDiff;



3. 
create database temp8

create table EMP8
(
EMPId int primary key,
Name varchar(25)not null,
salary int,
Deptno int
)



select * from emp8



a. accept only 10,20,30 as deptno



alter table emp8
add constraint colcheck check( deptno between 10 and 30)



b. Every employee salary must be in the range of 5000 to 50000 only
alter table emp8
add constraint salcheck check( salary between 5000 and 50000) 





