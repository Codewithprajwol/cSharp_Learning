using System;

namespace BasicLanguageConstruct{

    class BSC{
        static void Main(string[] args){
            int x=10;
            Console.WriteLine($"hello boy the number is {x}");

            //   string [] fruits= new string [] {"apple", "banana", "orange"};

              string [] fruits= ["apple", "banana", "orange"];

              foreach(string fruit in fruits){
                    Console.WriteLine(fruit);
              }

            // string [] fruits= new string [3];
            // fruits[0]="apple";
            // fruits[1]="banana";
            // fruits[2]="orange";
            // Console.WriteLine($"The fruits are {fruits[0]}, {fruits[1]}, {fruits[2]}");
    }
}
}