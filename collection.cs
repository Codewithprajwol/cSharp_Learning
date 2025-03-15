using System;
using System.Collections;


namespace collection{
    class Progam{
        public static void Main(string [] args){
            int [] number =new int [3];
            List<string> meroList= new List<string>();
            meroList.Add("hello");
            meroList.Add("fello");

            foreach(string listi in meroList){
                Console.WriteLine(listi);
            }
        }
    }
}