using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_hw_37
{
    public class Customer
    {

        public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {

            switch (e.Action)

            {


                case NotifyCollectionChangedAction.Add:
                    if (e.NewItems?[0] is Item newItem)
                        Console.WriteLine($"Добавлен новый товар: ID = {newItem.Id}, Название {newItem.Name}");
                    break;
               
                case NotifyCollectionChangedAction.Remove:
                    if (e.OldItems?[0] is Item oldItem)
                        Console.WriteLine($"Удалён товар:  {oldItem.Name}");
                    break ;


             }
        
        }


    



    }





}
