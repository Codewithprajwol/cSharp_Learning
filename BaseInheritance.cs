// using System;
// using System.Security.Cryptography;
// using System.Security.Cryptography.X509Certificates;

// namespace BaseInheritance{
//    class Animal{
//         protected bool sleep=false;
//         private string name=string.Empty;
//         public Animal( string parechaya){
//             this.name=parechaya;
//             Console.WriteLine($"{name} is sleeping ? {sleep}");
//         }
//    }
//    class Dog:Animal{
//     public int age;
//     public string bread;
//     public Dog(int age, string bread):base("tommy"){
//         this.age=age;
//         this.bread=bread;
//     Console.WriteLine(base.sleep);
//     }

//    }
//     class Program{
//         static void Main(string [] args){
//          Dog mydog=new (12,"bull");
         
//         }
//     }
// }


// using System;

// namespace baseInterihance{
//     class Person{
//         private string name=String.Empty;
//         private int age;

        // public string Name {
        //     get{
        //         return name;
        //     }
        //     set{
        //         name=value;
        //     }
        // }
        // public int Age{
        //     get{
        //         return age;

        //     }
        //     set{
        //         age=value;
        //     }

        // }
//         public Person(string name, int age){
//             this.name=name;
//             this.age=age;
//         }
        
//         public void printName(){
//             Console.WriteLine($"hello my name is {name}");
//         }
//     }
//     class Prajwol:Person{
//         private string Gender;
//         public Prajwol(string gender,string a, int b):base(a,b){
//             this.Gender=gender;
//         }
//     }
//     class Program{
//         public static void Main(){
//             Prajwol p=new Prajwol("Male","Prajwol",12);
//             p.printName();
//         }
//     }
// }