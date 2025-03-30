// using System;

// //Remember that the abstract class is class where we cannot instanciate object .. the derived class should implement the abstract method and derive abastract class;

// namespace abstractclass{
//     //    sealed class Person{
//        abstract class Person{
//          protected string name=string.Empty;
//          protected int age;
//          protected string gender=string.Empty;
//            public abstract string Printname();
//        }

//        class Employee:Person{// here if base class is created using Sealed then it will gve error here

//         public string Name{
//             get{
//                 return name;
//             }
//             set{
//                 name=value;
//             }
//         }
//         public int Age{
//             get{
//                 return age;
//             }
//             set{
//                 age=value;
//             }
//         }
//         public string Gender{
//             get{
//                 return gender;
//             }
//             set{
//                 gender=value;
//             }
//         }

//         public override string Printname(){
//                  Console.WriteLine($"name is {Name},{Age}, {Gender}");
//         return "hello";
//         }

//        }

//     class Program{
//         static void Main(string[] args){
//           Employee emp1=new Employee(){Name="prajwol",Age=12,Gender="male"};
//           emp1.Printname();
//         }
//     }
// }


// using System;
// namespace abstractClass{
//         abstract class Person{
//             protected string name=string.Empty;
//             protected int age;
//             public abstract void printname();
//         }

//         class Prajwol:Person{
//             public string  Name{ get{ return name;} set {name=value;}}
//             public int Age {get{ return age;} set{age=value;}}

//             public override void printname(){
//                 Console.WriteLine($"name is {Name} and age is{Age}");
//             }
//         }
//         class Program{
//             static void Main(string [] args){
//             Prajwol p = new Prajwol()
//             {
//                 Name = "prajwol",
//                 Age = 12
//             };
//             p.printname();
//             }
            
//         }
// }