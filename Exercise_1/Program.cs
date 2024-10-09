

using System.Net.Http.Headers;

public class Exercise1
{
    public static void Main()
    {
        //q1();
        //q2 ();
        //q3 ();
        //q4 ();
        //q5 ();
        q6 ();
        //q7 ();
        //q8 ();
        //q9 ();
        //q10();

        Console.ReadKey();
    }
    public static void q1()
    {
        Console.WriteLine("Q1: Add/ Sum two numbers");
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap b; ");
        int b = int.Parse(Console.ReadLine());
        int c = a + b;
        Console.WriteLine($"{a}+{b}={c}");
    }
    public static void q2()
    {
        Console.WriteLine("Q2: Swap values of two variables");
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());
        int c = b;
        b = a;
        a = c;
        Console.WriteLine($"Gia tri moi cua a la {a}");
        Console.WriteLine($"Gia tri moi cua b la {b}");

    }
    public static void q3()
    {
        Console.WriteLine("Q3:Multiply two Floating Point Numbers");
        Console.Write("nhap so thuc a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("nhap so thuc b: ");
        float b = float.Parse(Console.ReadLine());
        float c = a * b;
        Console.WriteLine($"{a}*{b}={c}");
    }
    public static void q4()
    {
        Console.WriteLine("Q4: Convert feet to meter");
        Console.Write("Input feet = ");
        double a = double.Parse(Console.ReadLine());
        double c = a * 0.3048;
        Console.WriteLine($"{a} feet ={c} meter(s)");
    }
    public static void q5()
    {
        Console.WriteLine("Q5: Convert Celsius to Fahrenheit and vice versa");
        Console.Write("Input Celsius degree = ");
        double a = double.Parse(Console.ReadLine());
        double c = (a * 1.8 + 32);
        double d = (a - 32) / 1.8;
        Console.WriteLine($"{a} do C ={c} do F");
        Console.WriteLine($"{a} do F ={d} do C");
    }
    public static void q6()
    {
        Console.WriteLine("Q6: Find the Size of data types");
        int s = sizeof(int);
        Console.WriteLine($"VD: kich thuoc cua int la {s}");
        /*sizeof(sbyte);
        sizeof(short);
        sizeof(ushort);
        sizeof(int);
        sizeof(uint);
        sizeof(long);
        sizeof(ulong);
        sizeof(char);
        sizeof(float);
        sizeof(double);
        sizeof(decimal);
        sizeof(bool);
        */

    }
    public static void q7()
    {
        Console.Write("Nhap ky tu: ");
        Char a = Char.Parse(Console.ReadLine());
        int maso = a;
        Console.WriteLine($"{a} in ASCII = {maso}");
    }
    public static void q8()
    {
        Console.Write("nhap ban kinh: ");
        float a = float.Parse(Console.ReadLine());
        double s = Math.PI * Math.Pow(a, 2);
        Console.WriteLine($"Dien tich hinh tron la {s}");
    }
    public static void q9()
    {
        Console.Write("nhap do dai canh: ");
        float a = float.Parse(Console.ReadLine());
        double s = a*a;
        Console.WriteLine($"Dien tich hinh vuong la {s}");
    }
    public static void q10()
    {
        Console.Write("Nhap so ngay bat ky: ");
        int d = int.Parse(Console.ReadLine());
        int y = d / 365;
        int w = (d - y * 365) / 7;
        int le = d % 7;
        Console.WriteLine($"{d} ngay bang {y} nam, {w} tuan, {le} ngay");
    }
}
