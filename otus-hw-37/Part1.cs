using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace otus_hw_37
{
    internal class Part1
    {
        public ImmutableList<string> Poem { get; set; }

        public void AddPart(ImmutableList<string> inputList)
        {

            var l1 = inputList.Add("Вот дом,");
            var l2 = l1.Add("Который построил Джек.");
            Poem = l2;
        }




    }
}
