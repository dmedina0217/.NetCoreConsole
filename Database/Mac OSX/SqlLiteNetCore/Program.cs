using System;
using System.Linq;

namespace NetCore.SQLite
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello Writing From Mac OSX !");
            Console.WriteLine("Daniel Medina--NetCore.SQLite Test.1");
            using(var db=new BloggingContext()){
                
                

                Console.WriteLine("Enter New Name For Blog: ");
                var name=Console.ReadLine();
                Console.WriteLine("Enter New Url: ");
                var url=Console.ReadLine();
                while(name != "quit"){
                    var blog=new Blog(){Name=name,Url=url};
                    db.Blogs.Add(blog);
                    db.SaveChanges();
                    var querys= from b in db.Blogs orderby b.Name select b;
                    foreach(var c in querys){
                        Console.WriteLine("Blogs in Database: " +"Id: "+ c.BlogId +" "+"Name: "+  c.Name + "Url: "+ c.Url);

                    }
                    Console.WriteLine("Enter New Name For Blog: ");
                    name=Console.ReadLine();
                    Console.WriteLine("Enter New Url: ");
                    url=Console.ReadLine();

                }
                Console.WriteLine("Exiting Adding...");
                
                /*
                var blogs= db.Blogs.ToList();
                foreach(var x in blogs){
                    Console.WriteLine(x.Name);
                }
                Console.WriteLine("Select A Blog By Name: ");
                var getName = Console.ReadLine();
                var single = db.Blogs.Single(b=>b.BlogId == 1);
                */
                var blogs= db.Blogs.ToList();
                foreach(var x in blogs){
                    Console.WriteLine("Blogs in Database: " +x.Name);
                }
                Console.WriteLine("Enter 'quit' to Exit");
                Console.WriteLine("Delete Blog: ");
                string deleteBlog=Console.ReadLine();
                while(deleteBlog != "quit"){
                    
                    
                    
                    Console.WriteLine("Deleting... "+deleteBlog);
                    db.Blogs.RemoveRange(db.Blogs.Where(x => x.Name == deleteBlog ));
                    db.SaveChanges();
                    var query= from b in db.Blogs orderby b.Name select b;

                    foreach(var x in query){
                        Console.WriteLine(x.Name);
                    }
                    Console.WriteLine("Enter 'quit' to Exit");
                    
                    Console.WriteLine("Delete Blog: ");
                    deleteBlog=Console.ReadLine();
                }
                



                
                
                Console.WriteLine("Exiting....");
                var blogss= db.Blogs.ToList();
                foreach(var x in blogss){
                    Console.WriteLine("Blogs in Database: " +x.Name);
                }
                Console.ReadKey();
            }

        }
    }
}
