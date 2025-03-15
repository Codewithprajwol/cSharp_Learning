using System;

namespace BasicLanguageConstruct{

    class BSC{
        static void Main(string[] args){
            int x=10;
            Console.WriteLine($"hello boy the number is {x}");

            //   string [] fruits= new string [] {"apple", "banana", "orange"};

              string [] fruits= ["apple", "banana", "orange"];//one dimensional array

              int [,] numbers= new int [2,3]{// two dimensional array
                {1,2,3},
                {4,5,6}
              };
              Console.WriteLine(numbers[1,2]);// 

              foreach(string fruit in fruits){
                    Console.WriteLine(fruit);
              }

            // string [] fruits= new string [3];
            // fruits[0]="apple";
            // fruits[1]="banana";
            // fruits[2]="orange";
            // Console.WriteLine($"The fruits are {fruits[0]}, {fruits[1]}, {fruits[2]}");

            // jagged array
            int [][] jaggedArray= new int [3][];
            jaggedArray[0]= new int [2]{1,2};
            jaggedArray[1]= new int [3]{3,4,5};
    }
}
}