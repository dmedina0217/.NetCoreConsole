using System;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is from .NET Core !");
            Console.WriteLine();
            Console.WriteLine("Writing and Reading From A File");
            Console.WriteLine();
            //Create a new file

            string information = "hello I am in a test file. This was written from Visual Studio Code";
            File.WriteAllText("/Users/Danny/Source/Repos/.NetCore Console Projects/test1.txt",information);

            //Read Contents of File
            string fileContents=File.ReadAllText("/Users/Danny/Source/Repos/.NetCore Console Projects/test1.txt");
            Console.WriteLine(fileContents);
            Console.WriteLine("Everything Worked!");

            //Writing To Array
            string[] arrayInfo=new string[2];
            arrayInfo[0]="this is line 1";
            arrayInfo[1]="this is line 2";
            File.WriteAllLines("/Users/Danny/Source/Repos/.NetCore Console Projects/arrayTest.txt",arrayInfo);

            //Reading From Array File
            string[] fileArray = File.ReadAllLines("/Users/Danny/Source/Repos/.NetCore Console Projects/arrayTest.txt");
            //Loop through each line
            foreach(string n in fileArray){
                Console.WriteLine("File Array Contents: "+n);

            }
            Console.WriteLine("Exiting...");

             
	    
        }
    }
}
