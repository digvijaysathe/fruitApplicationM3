using fruitApplicationM3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fruitApplicationM3.Repository
{
    public interface IFruitrepo
    {
        List<Fruit> GetFruits();
        void Createfruit(Fruit fruit);
    }
}
