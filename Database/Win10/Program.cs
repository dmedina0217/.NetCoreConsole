using System;

namespace NetCoreDatabaseProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using(var db=new BloggingContext()){
                Console.WriteLine("Enter your Blog Name");
                var response=Console.ReadLine();

                db.Blogs.Add(new Blog{Name=response});
                db.SaveChanges();

                Console.WriteLine("Blogs in database: ");
                foreach(var blog in db.Blogs){
                    Console.WriteLine(blog.Name);
                }
            }
        }
    }
}
