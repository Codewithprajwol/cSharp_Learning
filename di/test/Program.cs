using System;
using test.Models;

namespace progamcs{
    class Program {

        static void Main( string [] args){
            Home home= new Home();
            Person p1= new Person(home){name="prajwol"};
            p1.teaching=new College();
            p1.printName();
            p1.goHome();
            p1.goSchool();
            p1.goHospital(new Hospital());
        }
    }
}