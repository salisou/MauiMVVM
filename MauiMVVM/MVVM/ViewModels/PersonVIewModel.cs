using MauiMVVM.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMVVM.MVVM.ViewModels
{
    public class PersonVIewModel
    {
        public List<Person> Persons { get; set; } = new List<Person>();

        public PersonVIewModel()
        {
            Persons.Add(new Person() { Name = "Marco", Age = 42, Married = true, BirthDate = new DateTime(2023, 11, 10), Weigth = 80, Lunchtime = new TimeSpan(10,0,0)});
            Persons.Add(new Person() { Name = "Michelle", Age = 42, Married = true, BirthDate = new DateTime(2023, 11, 10), Weigth = 50, Lunchtime = new TimeSpan(10,0,0)});
            Persons.Add(new Person() { Name = "Andre", Age = 42, Married = true, BirthDate = new DateTime(2023, 11, 10), Weigth = 30, Lunchtime = new TimeSpan(10,0,0)});
            Persons.Add(new Person() { Name = "Slee", Age = 42, Married = true, BirthDate = new DateTime(2023, 11, 10), Weigth = 50, Lunchtime = new TimeSpan(10,0,0)});
            Persons.Add(new Person() { Name = "Sonny", Age = 42, Married = true, BirthDate = new DateTime(2023, 11, 10), Weigth = 70, Lunchtime = new TimeSpan(10,0,0)});
            Persons.Add(new Person() { Name = "Davide", Age = 42, Married = true, BirthDate = new DateTime(2023, 11, 10), Weigth = 20, Lunchtime = new TimeSpan(10,0,0)});
            Persons.Add(new Person() { Name = "Hellene", Age = 42, Married = true, BirthDate = new DateTime(2023, 11, 10), Weigth = 10, Lunchtime = new TimeSpan(10,0,0)});
            Persons.Add(new Person() { Name = "Booba", Age = 42, Married = true, BirthDate = new DateTime(2023, 11, 10), Weigth = 90, Lunchtime = new TimeSpan(10,0,0)});
        }
    }
}
