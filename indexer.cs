using System;


 namespace indexer{
    class Program{
        class IndexerClass{
            //first define array 
            //and make method name by this keyword with paramater int i and use get and set 
            private string[] names=new string[10];
            public string this [int i]{
                get {
                    return names[i];
                    }
                set{
                    names[i]=value;
                }
            }
        }
        static void Main(string[] args){
        var team=new IndexerClass();
        team[0]="ram";
        team[1]="sam";
        Console.WriteLine($"first name is {team[0]}");
}// this is the use of indexer
    }
}