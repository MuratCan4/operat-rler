using System;

namespace operatorler
{
    class Program
    {

        static void Main (string[] args)
        {
            int sayi1 = 5;
            int sayi2 = 10;

            sayi1 += 22;
            sayi2 -= sayi1;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);

            bool isSuccess = true;
            bool isComplate = false;

            if (isSuccess && isComplate)
            {
                Console.WriteLine("Perfect!");
            }
             if (isSuccess || isComplate)
            {
                Console.WriteLine("Great!");
            }
             if (isSuccess && !isComplate)
            {
                Console.WriteLine("Fine!");
            }

            int a = 5;
            int b = 7;

            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
             Console.WriteLine(sonuc);
             sonuc = a==b;
             Console.WriteLine(sonuc);
             sonuc = a>=b;
             Console.WriteLine(sonuc);
             sonuc = a<=b;
             Console.WriteLine(sonuc);
             sonuc = a!=b;
             Console.WriteLine(sonuc);

             int op;

             op = a/b;
             Console.WriteLine(op);
             op = a*b;
             Console.WriteLine(op);
             op = a%b;
             Console.WriteLine(op);
        }
    }
}