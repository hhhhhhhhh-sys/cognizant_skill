using System;


class Program
{


    static double FutureValue(double value,double growth,int years)
    {

        if(years==0)
        {
            return value;
        }


        return FutureValue(
            value*(1+growth),
            growth,
            years-1
        );

    }



    static void Main()
    {


        double currentValue=10000;

        double growthRate=0.10;

        int years=5;



        double result=FutureValue(
            currentValue,
            growthRate,
            years
        );



        Console.WriteLine("Financial Forecasting");


        Console.WriteLine(
        "Initial Value: "+currentValue);



        Console.WriteLine(
        "Growth Rate: "+growthRate*100+"%");



        Console.WriteLine(
        "Future Value: "+result);



        Console.WriteLine();



        Console.WriteLine(
        "Recursion means a function calling itself until base condition.");



        Console.WriteLine(
        "Time Complexity: O(n)");



        Console.WriteLine(
        "Optimization: Use Memoization to store previous results.");

    }

}