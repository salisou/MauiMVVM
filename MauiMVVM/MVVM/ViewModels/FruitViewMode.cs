using MauiMVVM.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMVVM.MVVM.ViewModels
{
    public class FruitViewMode
    {
        public List<Fruit> Fruit { get ; set; }
        public FruitViewMode()
        {
            Fruit = new List<Fruit>
            {
                new Fruit
                {
                    FruitName = "Apple",
                    FruitDescription = "An apple is an edible fruit produced \nby an apple tree (Malus domestica)."
                },

                new Fruit
                {
                    FruitName = "Orange",
                    FruitDescription = "The orange is the fruit of various citrus \nspecies in the family Rutaceae."
                },

                new Fruit
                {
                    FruitName = "Banana",
                    FruitDescription = "A long curved fruit with soft pulpy \nflesh and yellow skin when ripe."
                },

                new Fruit
                {
                    FruitName = "Grape",
                    FruitDescription = "A berry growing in clusters on a grapevine, \neaten as fruit and used in making wine."
                },

                new Fruit
                {
                    FruitName = "Mango",
                    FruitDescription = "A mango is an edible stone fruit produced \nby the tropical tree Mangifera indica."
                }
            };
        }
    }

}
