using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace otus_hw_37
{
    public class MyLibrary
    {

        public ConcurrentDictionary<string, int> Library = new ConcurrentDictionary<string, int>();

        
        int milliseconds = 1000;
        
        public void AddBook (string name)

        {

            if (!Library.ContainsKey(name));
            {
                Library.TryAdd(name, 0);
            }

            Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(milliseconds);
                    Library[name] = i;
                }
                var gg = Library[name];
                Library.Remove(name, out gg);
                             
            });


        }
       
        public void GetBooks() 
        {

            foreach (var book in Library)
            Console.WriteLine($"Название - {book.Key}, прочитано  {book.Value} %" );

        }



    }
}
