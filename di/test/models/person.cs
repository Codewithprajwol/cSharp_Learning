using System;
using test.Models;

namespace test.Models
{
    class Person{
        private Home _home;
        private School _school;
        private  Hospital _hospital;

        public string name=string.Empty;

        public Person()
        { 
            this._home=new Home();
            this._school=new School();
            this._hospital=new Hospital();
        }
        
        public void printName(){
            Console.WriteLine($"name is {name}");
        }
        public void goHome(){
            Console.WriteLine("hello from home");
            _home.dohomework(this);
        }
         
         public void goSchool(){
            Console.WriteLine(" go to school");
            _school.doschoolwork(this);
         }

         public void goHospital(){
            Console.WriteLine("go to hospital");
            _hospital.doHospitalwork(this);
         }
        

    }
}