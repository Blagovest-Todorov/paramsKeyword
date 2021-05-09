using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Program
    {

        static long SumNums(string print, params int[]array) 
        {
            Console.WriteLine(print);
            long sum = 0;

            foreach (var num in array)
            {
                sum += num;
            }

            return sum;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(SumNums("Hello", 1,2,3));  
        }

        //By using a keyword params,in a method you allow and specify this method
        //to take variable numer of argumets
        // no aditional arguments are allowed in method declaration after param keyword,
        // and only one params keyword is allowed in method declaration
        //when You call a method with keyword params parameter you may pass in:
        //comma separated list of arguments of teh type of teh array eleemtns
        //an array of arguments of teh special type, 
        //no arguments, if You send no arguments, the length of params list is zero/
        //with params keyword, a method can take a variable number of arguments. 
        //it is useful when teh programmer does not  know how many parametes will take the method,
        //only one keyword params is allowed in a method, after params keyword, no other paramter is allowed/
    }
}
