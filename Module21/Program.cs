using System;
using Module21.Models;

namespace Module21
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new FindInFileSystem("ExampleJsons", typeof(Book).Namespace!);
            foreach (var item in repository.FindByNumber(123456))
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");
        }
    }
}