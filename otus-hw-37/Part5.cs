using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_hw_37
{
    internal class Part5
    {
        public ImmutableList<string> Poem { get; set; }

        public void AddPart(ImmutableList<string> inputList)
        {

            var l1 = inputList.Add("Вот пес без хвоста,\r\nКоторый за шиворот треплет кота,\r\nКоторый пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.");
            Poem = l1;
        }
    }
}
