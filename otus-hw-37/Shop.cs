using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_hw_37
{
    public class Shop
    {
        public ObservableCollection<Item> Goods = new ObservableCollection<Item>();
        
        
        public void Add (Item item)
        {
        Goods.Add (item);
        }

        public void Remove (int id)
        {
            int i = 0;

            foreach (var a in Goods)
            {
                if (a.Id == id)
                {
                    Goods.Remove(a);
                    i = 1;
                    break;
                }                        
            }

            if (i == 0) Console.WriteLine("Тавара с таким ID нет в магазине");

        }       

    }
}
