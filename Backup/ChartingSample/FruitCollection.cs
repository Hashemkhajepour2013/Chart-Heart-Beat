using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChartingSample
{
    class FruitCollection : System.Collections.ObjectModel.Collection<Fruit>
    {
        public FruitCollection()
        {
            Add(new Fruit { Name = "Mango", Share = 10 });
            Add(new Fruit { Name = "Banana", Share = 36 });
            Add(new Fruit { Name = "Apple", Share = 24 });
            Add(new Fruit { Name = "Guava", Share = 4 });
            Add(new Fruit { Name = "Orange", Share = 12 });
            Add(new Fruit { Name = "Pear", Share = 10 });
            Add(new Fruit { Name = "Pineapple", Share = 4 });
        }
    }
}
