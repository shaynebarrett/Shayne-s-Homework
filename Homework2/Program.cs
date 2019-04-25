using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework2
{

    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

          

            var displayHelloPWs =
                from user in users
                where user.Password == "hello"
                select user;

            Console.WriteLine("Problem 1");
            
            Console.WriteLine("Here are all of the Name's who have 'Hello' as their password: ");
            foreach (var element in displayHelloPWs)
            {
                Console.WriteLine($"Name = {element.Name}; Password = {element.Password} ");
            }
            Console.WriteLine("**************************************");
            Console.WriteLine("Problem 2");
            var deleteLowercase = users.Find(t => t.Name.ToLower() == t.Password);
            if (deleteLowercase != null)
            {
                users.Remove(deleteLowercase);
            }
            foreach (var element in users)
            {
                Console.WriteLine($"Name = {element.Name}; Password = {element.Password} ");
            }


            //var deleteLowercase =
            //    from user in users
            //    let lowercaseName = user.Name.ToLower()
            //    where user.Name == user.Password
            //    select user;


            Console.WriteLine("**************************************");
            Console.WriteLine("Problem 3 and Problem 4");
            var findFirsthello = users.FirstOrDefault(t => t.Password == "hello");
            if (findFirsthello != null)
            {
                users.Remove(findFirsthello);
            }
            
            foreach (var user in users)
            {
                Console.WriteLine($"Name = {user.Name}; Password = {user.Password} ");
            }
            
               
            



            

            
           






        }
    }
}
