using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelBlog.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelBlog.Controllers
{
    public class PeopleController : Controller
    {
        private TravelBlogContext db = new TravelBlogContext();

        public IActionResult Index()
        {
            return View(db.People.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisPerson = db.People.Include(person => person.Experience)
                               .FirstOrDefault(person => person.PersonId == id);
            return View(thisPerson);
        }
        public IActionResult Create(int experienceId)
        {
            var thisExperience = db.Experiences.FirstOrDefault(experiences => experiences.ExperienceId == experienceId);
            ViewBag.CurrentExperience = thisExperience;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            db.People.Add(person);
            db.SaveChanges();
            return RedirectToAction("Details", "Experiences", new{id = person.ExperienceId});
        }

        public IActionResult Edit(int id)
        {
            var thisPerson = db.People.FirstOrDefault(person => person.PersonId == id);
            return View(thisPerson);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            db.Entry(person).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisPerson = db.People.FirstOrDefault(person => person.PersonId == id);
            return View(thisPerson);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmation(int id)
        {
            var thisPerson = db.People.FirstOrDefault(person => person.PersonId == id);
            db.People.Remove(thisPerson);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AddExperience(int PersonId)
        {
            var thisPerson = db.People
                                   .FirstOrDefault(person => person.PersonId == PersonId);
            ViewBag.ExperienceId = new SelectList(db.Experiences, "ExperienceId", "Title");
            return View(thisPerson);
        }

        [HttpPost]
        public IActionResult AddExperience(Person person)
        {
            db.People.Add(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
