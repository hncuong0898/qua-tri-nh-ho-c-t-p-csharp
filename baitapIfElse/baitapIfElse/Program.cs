using System;

namespace baitapIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, old;
            int olds;
            Console.Write("Nhap ten cua ban :");
            name = Console.ReadLine();
            Console.Write("Nhap tuoi cua ban :");
            old = Console.ReadLine();
            olds = Int32.Parse(old);
            if (olds > 18)
            {
                Console.WriteLine("Xin chao " + name);
            }
            else
            {
                return;
            }
            Console.ReadKey();
        }
    }
        
}
