// using System;

// namespace inheritance{
//     class Person{
//         protected string name=string.Empty;
//         protected int age;

//         public void printFullName(){
//             var fullName=name+age;
//             Console.WriteLine("full name is {0}",fullName);
//         }
//     }
//     class User:Person{
//         private string gender;

//         public User(string gender, string name, int age){
//             this.gender=gender;
//             this.age=age;
//             this.name=name;

//         }

//         public void Display(){
//             Console.WriteLine($"{name},{age},{gender}");
//         }
//     }
//      class Program{
//         static void Main(string[] args){
//             User user1=new User("male","prajwol",13);
//             user1.Display();
//             user1.printFullName();
//         }

//      }
// }