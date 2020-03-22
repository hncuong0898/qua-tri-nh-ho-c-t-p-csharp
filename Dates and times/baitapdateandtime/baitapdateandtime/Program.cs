using System;

namespace baitapdateandtime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime ngaysinh;
            string ngaysinhh;
            
            Console.Write("Nhap vao ngay sinh cua ban :");
            ngaysinhh=Console.ReadLine();
            ngaysinh = DateTime.Parse(ngaysinhh);
            TimeSpan Daylife = DateTime.Today - ngaysinh;
            Console.WriteLine("Ngay sinh cua ban la : " + ngaysinhh);
            Console.WriteLine("So ngay ban da song : " + Daylife.TotalDays);
            Console.ReadKey();
            
        }
    }
}
