
using System;
class FunctionTest()
{
    //static void Main(String[] args)
    //{
    //    DoubleTest();
        
    //}

    public void DoubleTest()
    {
        int num1 = 10;
        DoubleInt(ref num1);

        Console.WriteLine("DoubleTest "+num1.ToString());
    }


    public void DoubleInt(ref int num)
    {
        num *= 2;
        Console.WriteLine("DoubleInt is "+num.ToString());
    }
}