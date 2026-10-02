

//базовый уровень вар 22
//try
//{
//    Console.Write("Введите объём 1:");
//    double v1 = double.Parse(Console.ReadLine());
//    Console.Write("Введите массу 1:");
//    double m1 = double.Parse(Console.ReadLine());
//    Console.Write("Введите объём 2:");
//    double v2 = double.Parse(Console.ReadLine());
//    Console.Write("Введите массу 2:");
//    double m2 = double.Parse(Console.ReadLine());
//    double p1 = m1 / v1;
//    double p2 = m2 / v2;
//    if (p1 > p2)
//        Console.WriteLine("Материал первого тела имеет большую плотность");
//    else Console.WriteLine("Материал второго тела имеет большую плотность");

//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//Сред ур 22 вар

//try
//{
//    Console.Write("Введите точку a:");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("Введите точку b:");
//    double b = double.Parse(Console.ReadLine());
//    Console.Write("Введите точку c:");
//    double c = double.Parse(Console.ReadLine());
//    if ((a < b) && (b < c) || (a > b) && (b > c))
//        Console.WriteLine("точка b ближе к a");
//    else Console.WriteLine("точка с ближе к a");

//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
//высокий уровень вар 22
try
{
    Console.Write("Введите удельное сопротивление r1:");
    double r1 = double.Parse(Console.ReadLine());
    Console.Write("Введите удельное сопротивление r2:");
    double r2 = double.Parse(Console.ReadLine());
    Console.Write("Введите удельное сопротивление r3:");
    double r3 = double.Parse(Console.ReadLine());

    Console.Write("Введите площадь сечения s1:");
    double s1 = double.Parse(Console.ReadLine());
    Console.Write("Введите площадь сечения s2:");
    double s2 = double.Parse(Console.ReadLine());
    Console.Write("Введите площадь сечения s3:");
    double s3 = double.Parse(Console.ReadLine());

    double p1 = r1 / s1;
    double p2 = r2 / s2;
    double p3 = r3 / s3;

    if ((p1 > p2) && (p1 > p3))
        Console.WriteLine("Первый проводник с максимальным сопротивлением");
    else if ((p2>p1)&&(p2>p3))
        Console.WriteLine("Второй проводник с максимальным сопротивлением");

    else Console.WriteLine("Третий проводник с максимальным сопротивлением");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


