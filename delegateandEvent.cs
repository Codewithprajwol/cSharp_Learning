// using System;

// namespace deleagateandEvent{

//     delegate void delegateFunction();
//     class Program {

//         static void Main(string [] args){
//         delegateFunction delegator=new delegateFunction(Myfunc);
//         delegator();
//         }
//     public static void Myfunc(){
//       Console.WriteLine("hello from neapl");
//     }
//     }
// }


// using System;
// using System.Runtime.CompilerServices;
// namespace delegates{
//     class Progam{
//         public delegate int myDelegate(int i);
//         public static void Main(string [] args){
//                 myDelegate d=y=>y*y;
//                 int j=d(12);
//         Console.WriteLine("d is {0}",j);
//         }
//     }
// }