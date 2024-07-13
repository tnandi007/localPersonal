using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoDBContext();



            ////Adding new records to Post table
            var newPost = new Post()
            {
                DatePublished = DateTime.Today,
                Body = "Test Body",
                Title = "Test Title"

            };

         

            context.Posts.Add(newPost);
            context.SaveChanges();

            var newAuthor = new Author()
            {
                Name = "Tatha"
            };

            context.Authors.Add(newAuthor);
            context.SaveChanges();

            //Fetching records from Posts table
            var rslt = context.Posts;
            foreach (var post in rslt)
            {
                Console.WriteLine(post.Title);

            }

            //Modifying a record in the Pots Table
            var rslt1 = context.Posts.FirstOrDefault();
            if (rslt1 != null)
            {
                rslt1.Title = "Modified Title";
            }

            context.SaveChanges();
        }
    }
}
