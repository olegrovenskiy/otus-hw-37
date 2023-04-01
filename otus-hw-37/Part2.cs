using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_hw_37
{
    internal class Part2
    {

        public ImmutableList<string> Poem { get; set; }

        public void AddPart(ImmutableList<string> inputList)
        {

            var l1 = inputList.Add("А это пшеница,");
            var l2 = l1.Add("Которая в темном чулане хранится");
            var l3 = l2.Add("В доме,");
            var l4 = l3.Add("Который построил Джек.");
            Poem = l4;
        }




    }
}
