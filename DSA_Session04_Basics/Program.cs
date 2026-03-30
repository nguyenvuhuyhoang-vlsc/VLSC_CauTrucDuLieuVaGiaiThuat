using System;
using System.Diagnostics;

// Author: Nguyen Vu Huy Hoang - 2500113459
// Muc tieu:
// Bai1: loi chao thong minh
// Yeu cau: nhap ten va MSSV, in ra loi chao
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhap ho ten: ");
        string name = Console.ReadLine();

        Console.Write("Nhap MSSV: ");
        string mssv = Console.ReadLine();

        Console.WriteLine($"Chao mung sinh vien {name} (MS: {mssv}) den voi lop CTD&");

        Console.Write("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tong: {a + b}");
        Console.WriteLine($"Hieu: {a - b}");
        Console.WriteLine($"Tich: {a * b}");

        if (b != 0)
        {
            Console.WriteLine($"Thuong: {(double)a / b}");
        }
        else
        {
            Console.WriteLine("Khong the chia cho 0!");
        }

        int x = 5, y = 10;
        Console.WriteLine($"Truoc khi Swap: x ={x}, y={y}");
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"Sau khi Swap: x={x}, y={y}");
    }
}