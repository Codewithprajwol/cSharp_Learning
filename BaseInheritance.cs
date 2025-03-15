using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace BaseInheritance{
   class Animal{
        protected bool sleep=false;
        private string name=string.Empty;
        public Animal( string parechaya){
            this.name=parechaya;
            Console.WriteLine($"{name} is sleeping ? {sleep}");
        }
   }
   class Dog:Animal{
    public int age;
    public string bread;
    public Dog(int age, string bread):base("tommy"){
        this.age=age;
        this.bread=bread;
    Console.WriteLine(base.sleep);
    }

   }
    class Program{
        static void Main(string [] args){
         Dog mydog=new (12,"bull");
         
        }
    }
}