using System;
using test.Models;

namespace test.Models
{
    class Person{
        private Home _home;
        private IEducationalInstution _teaching;
        private  Hospital _hospital;

        
        public IEducationalInstution teaching{
             set {
                _teaching=value;
             }
        }

        public string name=string.Empty;

        public Person(Home home)
        { 
            this._home=home;
            // this._school=new School();
            // this._hospital=new Hospital();
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
            _teaching.doschoolwork(this);
         }

         public void goHospital(Hospital hos){
            Console.WriteLine("go to hospital");
            _hospital.doHospitalwork(this);
         }
        

    }
}