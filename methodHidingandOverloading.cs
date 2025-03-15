// // using System;
// // using System.Dynamic;

// // namespace methodHidingAndOverloading{
// //     class Class1{
// //         public virtual void myMethod(){
// //             Console.WriteLine("hello from class1");
// //         }
// //     }
// //     class Class2:Class1{
// //            public int age {get; set;}
// //         private  string student=string.Empty;

// //         public string Student{

// //             get{
// //                 return student;
// //             }

// //         set{
// //             student=value;
// //         }
// //         }

        
       
// //        public void PrintClassStudent(){
// //         Console.WriteLine($"student name is {student} and age id {age}");
// //        }
// //         public override void myMethod(){
// //             Console.WriteLine("hello from japan");
// //         }
// //     }
// //     class Program{
     

// //         static void Main(string [] args){
// //          Class2 testClass2=new Class2(){Student="prajwol",age=12};
// //          testClass2.PrintClassStudent();
// //          testClass2.myMethod();
// //         }
// //     }
// // }

// //here virtual and override is used

// //REEMEBER 
// // for private memeber if you have created the public memember then use like Student { get; set;}



// //METHOD HIDING

// using System;
// using System.Dynamic;

// namespace methodHidingAndOverloading{
//     class Class1{
//         public  void myMethod(){
//             Console.WriteLine("hello from class1");
//         }
//     }
//     class Class2:Class1{
//            public int age {get; set;}
//         private  string student=string.Empty;

//         public string Student{

//             get{
//                 return student;
//             }

//         set{
//             student=value;
//         }
//         }

        
       
//        public void PrintClassStudent(){
//         Console.WriteLine($"student name is {student} and age id {age}");
//        }
//         public new void myMethod(){
//             Console.WriteLine("hello from japan");
//         }
//     }
//     class Program{
//         static void Main(string [] args){
//          Class2 testClass2=new Class2(){Student="prajwol",age=12};
//          testClass2.PrintClassStudent();
//          testClass2.myMethod();
//         }
//     }
// }

// // this is method hiding example
