// using System;

// namespace inerfaceExample{
//      interface IAnimal{
//          public void IsSleepin();
//          public bool Dancing();
//      }
//      interface Icar{
//         public void CarModel();
//      }

//      class RichPerson:IAnimal,Icar{
//         public void IsSleepin(){
//             Console.WriteLine("dog is sleeping");
//         }

//         public bool Dancing(){
//             return false;
//         }

//         public void CarModel(){
//             Console.WriteLine("my car model in z243altrapromax");
//         }
//      }

//      class Program{
//         static void Main(string [] args){
//             RichPerson person=new RichPerson();
//             person.CarModel();
//             person.Dancing();
//             person.IsSleepin();
//         }
//      }
// }

using System;
namespace test {
    interface Idog{
        public void canEat();
        public bool canBark();
    }

    // class Animal{
    //     public string name=String.Empty;
    //     public int age;
    //     public string gender;
    // }
    class Dog:Idog{
         public string name=String.Empty;
        public int age;
        public string gender=String.Empty;

        public bool canBark(){
            return false;
        }
        public void canEat(){
            Console.WriteLine("yes he can eat");
        }
    }
    class Program {
        public static void Main(string [] args){
            Dog d=new Dog(){name="rotwiler", age=12, gender="male"};
            bool z=d.canBark();
            d.canEat();
            Console.WriteLine(z);
        }
    }
}