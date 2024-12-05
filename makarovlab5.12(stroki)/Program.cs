//using System;
//using System.Diagnostics.Metrics;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine(CountBits(4));
//        Console.WriteLine(CountBits(10));
//        Console.WriteLine(CountBits(1));
//        Console.WriteLine(CountBits(32));
//    }
//    static int CountBits(int num)
//    {
//        string binary = Convert.ToString(num, 2);

//        int count = 0;

//        foreach (char bit in binary)
//        {
//            if (bit == '1')
//            {
//                count++;
//            }
//        }

//        return count;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine(Persistence(39));
//        Console.WriteLine(Persistence(9));
//        Console.WriteLine(Persistence(999));
//    }

//    static int Persistence(int num)
//    {
//        int countIter = 0;

//        while (num >= 10)
//        {
//            int product = 1;


//            foreach (char digit in num.ToString())
//            {
//                product *= digit - '0';
//            }

//            num = product;
//            countIter++;
//        }

//        return countIter;
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine(DigitalRoot(16));
//        Console.WriteLine(DigitalRoot(942));
//        Console.WriteLine(DigitalRoot(132189));
//        Console.WriteLine(DigitalRoot(493193));
//    }

//    static int DigitalRoot(int num)
//    {
//        while (num >= 10)
//        {
//            int sum = 0;

//            foreach (char digit in num.ToString())
//            {
//                sum += digit - '0';
//            }

//            num = sum;
//        }

//        return num;
//    }
//}

