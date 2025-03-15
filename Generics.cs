using System;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;


namespace genericsExample{
    class Program{
        class Love<T,U>{
            public required T name;
            public required U age;

            public required T lover;

            public void LovePlace<F>(F value){
                    Console.WriteLine("love place is Sambriddi college and ture love is {0}",value);
            }

        }
        static void Main(string [] args){
            Love<string, int> mylove=new Love<string, int>(){name="parajwol",age=12,lover="parjwol"};
            mylove.LovePlace<bool>(true);
            // mylove.name="bhagwan";
            // mylove.age=22;
            // mylove.lover="prajwol";
        }
    }
}