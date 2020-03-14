using System;

namespace parametros
{

    class avicci{

        public static void suma(ref int a){

            a++;

        }

        public static void resta(in int a, in int b, out int c){
            c = a - b;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
           int num = 7;int num2 = 5; int res = 0;
           avicci.suma(ref num);
           avicci.resta(in num, in num2, out res);
           Console.WriteLine(num);
           Console.WriteLine(res);
        }
    }
}
