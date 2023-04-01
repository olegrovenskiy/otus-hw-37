using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_hw_37
{
    internal class Part3
    {
        public ImmutableList<string> Poem { get; set; }

        public void AddPart(ImmutableList<string> inputList)
        {

            var l1 = inputList.Add("А это веселая птица-синица,");
            var l2 = l1.Add("Которая часто ворует пшеницу,");
            var l3 = l2.Add("Которая в темном чулане хранится");
            var l4 = l3.Add("В доме,");
            var l5 = l4.Add("Который построил Джек.");
            Poem = l5;
        }




    }



}

