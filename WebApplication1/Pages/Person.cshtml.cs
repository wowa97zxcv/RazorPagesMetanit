using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class PersonModel : PageModel
    {
        List<Person> people;
        public List<Person> DisplayedPeople { get; set; }
        //public Person Person { get; set; }
        public PersonModel()
        {
            people = new List<Person>()
            {
                new Person {Name="Tom", Age=23},
                new Person {Name="Sam", Age=25},
                new Person {Name="Bob", Age=23},
                new Person {Name="Tom", Age=25}
            };
        }

        public void OnGet()
        {
            DisplayedPeople = people;
        }

        public void OnPostByName(string name)
        {
            DisplayedPeople = people.Where(p => p.Name.Contains(name)).ToList();
        }

        public void OnPostByAge(int age)
        {
            DisplayedPeople = people.Where(p => p.Age == age).ToList();
        }

        public void OnPostGreaterThan(int age)
        {
            DisplayedPeople = people.Where(p => p.Age > age).ToList();
        }

        public void OnPostLessThan(int age)
        {
            DisplayedPeople = people.Where(p => p.Age < age).ToList();
        }

        /*public IActionResult OnGet(string name)
        {
            Person = people.FirstOrDefault(p => p.Name == name);
            if (Person == null)
                return NotFound("Такого пользователя не существует");
            return Page();
        }*/
    }
}
