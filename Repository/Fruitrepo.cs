using fruitApplicationM3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fruitApplicationM3.Repository
{
    public class Fruitrepo : IFruitrepo
    {
        private readonly DataContext db;
        public Fruitrepo(DataContext _db)
        {
            db = _db;
        }
        public void Createfruit(Fruit fruit)
        {
            db.Fruits.Add(fruit);
            db.SaveChanges();
        }

        public List<Fruit> GetFruits()
        {
            return db.Fruits.ToList();
        }
    }
}
