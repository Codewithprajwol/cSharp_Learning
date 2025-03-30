// using System;
// using System.Threading.Tasks;

// class Program
// {
//     static async Task Main()
//     {
//         Console.WriteLine("Start");

//         // Call the asynchronous method
//         await PrintMessageAsync();

//         Console.WriteLine("End");
//     }

//     static async Task PrintMessageAsync()
//     {
//         await Task.Delay(2000); // Simulate a delay (2 seconds)
//         Console.WriteLine("Hello from async method!");
//     }
// }


// using System;
// using System.Threading.Tasks;

// namespace asyncos{
//     class Program{
//         static async Task Main(string [] args){
//             Console.WriteLine("before delay");
//             await Program.PrintMessage();
//             Console.WriteLine("hello after delay");
            
//         }
//         static async Task PrintMessage(){
//             await Task.Delay(2000);
//             Console.WriteLine("hello from nepal");
//         }
//     }
// }