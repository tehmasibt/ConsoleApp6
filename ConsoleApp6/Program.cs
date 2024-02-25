// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Security;

Console.WriteLine("Hello, World!");


#region example-1
//int a = 26;
//if (a%2== 0)
//{
//    Console.WriteLine("cutdur");
//}
//else if (a%2== 1)
//{
//    Console.WriteLine("tekdir");
//}
//else
//{
//    Console.WriteLine("duzgun eded daxil edin");
//}
#endregion

#region example-2
//int x = 21;
//if (x % 3 == 0 && x % 7 == 0)
//{
//    Console.WriteLine("bolunur");
//}
//else
//{
//    Console.WriteLine("duzgun eded daxil edin");
//}
#endregion

#region example-3
//double a = 24;
//double b = 47;
//if (a % 2 == 0 && b % 2 == 0)
//{
//    Console.WriteLine(a + b);
//}
//else if (a % 2 == 1 && b % 2 == 0)
//{
//    Console.WriteLine(a * b);
//}
//else if (a % 2 == 0 && b % 2 == 1)
//{
//    Console.WriteLine(a / b);
//}
//else
//{
//    Console.WriteLine("duzgun eded daxil et");
//}
#endregion

#region example-4
//int a = 15;
//if (a > 15)
//{
//    Console.WriteLine("hava istidir");
//}
//else if (a < 15)
//{
//    Console.WriteLine("hava soyuqdur");
//}
//else if (a==15)
//{
//    Console.WriteLine("hava serindir");
//}
//else
//{
//    Console.WriteLine("dogru eded daxil edin");
//}
#endregion

#region example-5
//int a = 3;
//int b = 7;
//int c = 49;
//if (a >= 10 && a <= 100 && b >= 10 && b <= 100 && c >= 10 && c <= 100)
//{
//    Console.WriteLine(a+b+c);
//}
//else if (a >= 10 && a<= 100 && b >= 10 && b<= 100)
//{
//    Console.WriteLine(a+b);
//}
//else if (b >= 10 && b< 100 && c >= 10 && c <= 100)
//{
//    Console.WriteLine(b+c);
//}
//else if (a>=10 && a<= 100 && c>= 10 && c<= 100)
//{
//    Console.WriteLine(a+c);
//}
//else
//{
//    Console.WriteLine("duzgun eded daxil edin");
//}
#endregion

#region example-6
//int day = 5;

//switch (day)
//{
//    case 12:
//    case 1:
//    case 2:
//        Console.WriteLine("wINTER");
//        break;
//    case 3:
//    case 4:
//    case 5:
//        Console.WriteLine("SPRING");
//        break;
//    case 6:
//    case 7:
//    case 8:
//        Console.WriteLine("SUMMER");
//        break;
//    case 9:
//    case 10:
//    case 11:
//        Console.WriteLine("AUTUMN");
//        break;
//    default:
//        Console.WriteLine();
//        break;
//}
#endregion

#region example-7
//int a = 2;
//if (a > 2 && a < 6)
//{
//    Console.WriteLine("Spring");
//}
//else if (a > 5 && a < 9)
//{
//    Console.WriteLine("Summer");
//}
//else if (a > 8 && a < 12)
//{
//    Console.WriteLine("Autumn");
//}
//else if (a > 0 && a < 3)
//{
//    Console.WriteLine("Winter");
//}
//else if (a == 12)
//{
//    Console.WriteLine("Winter");
//}
//else
//{
//    Console.WriteLine("duzgun reqem daxil edin");
//}
#endregion

#region example-8
//int a = 496;
//int x =  a / 100;
//int b = (a / 10) % 10;
//int c =  a % 10;
//Console.WriteLine(x*b*c);
#endregion

#region example-nooo
//int n = 346;
//int sum = 0;
//int count = 0;
//int a = 0;
//while (a>1)
//{

//    a =n% 10;
//    sum += a;
//    count++;
//    n /= 10;
//}
//int avg = sum/count;
//Console.WriteLine(avg);
#endregion


#region example-10
//int a = 10;
//int b = 100;
//int count = 0;  
//int sum = 0;    
//if (a > b)
//{
//    Console.WriteLine("duzgun eded daxil et");
//}
//else
//{
//    for (int i = a; i <= b; i++)
//    {
//        if (b%i == 0)
//        {
//            count++;
//            sum += a;
//            if (count > 2)
//            {
//                break;
//            }
//        }
//    }
//}
//Console.WriteLine(sum);
#endregion

#region example-11
//int weekday = 5;
//switch (weekday)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;  
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thirsday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("Nerminle danisiram");
//        break;
//}
#endregion

#region example-12
//int a = 17;
//int b = 101;
//int count = 0;
//int sum = 0;
//for (int i = a; i <= b; i++)
//{
//    if (i % 21 == 0)
//    {
//        count++;
//        sum += i;
//        if (count >= 2)
//        {
//            break;
//        }
//    }
//}
//int avg=sum / count;
//Console.WriteLine(avg);
#endregion

#region
//int a = -57;
//int b = 30;
//int sum = 0; 
//int count = 0;
//for (int i = a; i <= b; i++)
//{
//    if (i > 0 && i % 2 == 0)
//    {
//        sum += i;
//        count++;
//        if (count > 5)
//        {
//            break;
//        }
//    }
//}
//Console.WriteLine(sum);
#endregion

#region
//int a = 3524;
//int b = 81;
//if ( (a + b) >= 10 && (a + b) <= 100)
//{
//    Console.WriteLine(" cem 2 reqemlidir");
//}
//else if ( (a + b) >= 100 && (a+b) <=1000)
//{
//    Console.WriteLine(" cem 3 reqemlidir");
//}
//else
//{
//    Console.WriteLine("cem limiti asib");
//}
#endregion

#region example- reqemlerin kubu
//int x = 5;
//int mult = x * x * x;
//if ( mult>=1)
//{
//    Console.WriteLine(mult);
//}
#endregion

#region example- reqemlerin kubu Loop ile.
//int a = 1;
//int b = 10;
//for  (int i = a; i <= b; i++)
//{

//    int mult = i * i * i;

//    Console.WriteLine(mult);
//}
#endregion

#region example- teklerin cemi
//int a = 10;
//int sum = 0;
//for (int i = 1; i <= a; i++)
//{

//    if (i%2 == 1)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);
#endregion

#region example- faktorial
//int j = 5;
//int mult = 1;
//for (int i = 1; i <= j; i++)
//{
//    mult *= i;
//}
//Console.WriteLine(mult);
#endregion

#region example- tek ededlerin sayi
//int a = 29;
//int b = 40;
//int count = 0;  
//for (int i = a; i <= b; i++)
//{
//    if (i%2==1)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
#endregion

#region example- bolenlerin cemini tap
//int a = 45;
//int count = 0;
//int sum = 0;    
//for  (int i = 1; i <= a; i++)
//{
//    if (a%i == 0)
//    {
//        count++;
//        sum += i;
//        if (count >= 2)
//        {
//            break;
//        }
//    }
//}
//Console.WriteLine(sum);
#endregion

#region example- tam bolunme
//int a = 19;
//int b = 2;
//if (a % b == 0)
//{
//    Console.WriteLine("tam bolunur");
//}
//else
//{
//    Console.WriteLine("tam bolunmur");
//}
#endregion

#region example- reqemin nece mertebeli oldugunu tapin
//int a = 243224;
//int count = 0;
//while (a > 1)
//{
//    a /= 10;
//    count++;
//}
//Console.WriteLine(count);
#endregion






