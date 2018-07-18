using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_test
{
    public class A
    {
        public int m_inta,m_intb;
        public A()
        {
            m_inta=0;
            m_intb=0;
        }
        public A(int a,int b)
        {
            m_inta=a;
            m_intb=b;
        }        
    }
    class Program
    {
        static void pause()
        {
            Console.Write("Press any key to continue ...");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            A a = new A(100, 200);
            A b;
            System.Console.Write(a.m_inta + "\t" + a.m_intb + "\n");
            //為初始化b所以不能使用 System.Console.Write(b.m_inta + "\t" + b.m_intb + "\n");
            System.Console.Write("---------------\n");
            b = a;
            System.Console.Write(a.m_inta + "\t" + a.m_intb + "\n");
            System.Console.Write(b.m_inta + "\t" + b.m_intb + "\n");
            System.Console.Write("---------------\n");
            b.m_inta = 200;
            b.m_intb = 100;
            System.Console.Write(a.m_inta + "\t" + a.m_intb + "\n");
            System.Console.Write(b.m_inta + "\t" + b.m_intb + "\n");
            System.Console.Write("---------------\n");
            pause();

        }
    }
}
