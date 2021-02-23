using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatsMVC.Model;

namespace CatsMVC.Controller
{
    class CatsController
    {
        List<Cat> cats = new List<Cat>();

        public List<Cat> GetAll()
        {
            return cats;
        }

        public void Insert(Cat c)
        {
            cats.Add(c);
        }

        public void DeleteLast()
        {
            cats.RemoveAt(cats.Count - 1);
        }

        public void DeleteById(int id)
        {
            for (int i = 0; i < cats.Count; i++)
            {
                if (cats[i].Id == id)
                {
                    cats.RemoveAt(i);
                }
            }
        }

        public void UpdateById(int id, string name, int age)
        {
            for (int i = 0; i < cats.Count; i++)
            {
                if (cats[i].Id == id)
                {
                    cats[i].Name = name;
                    cats[i].Age = age;
                }
            }
        }
    }
}
