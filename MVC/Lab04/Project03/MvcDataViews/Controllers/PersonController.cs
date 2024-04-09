using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcDataViews.Models; // Lab4.3(3)6 добавилось

namespace MvcDataViews.Controllers
{
    public class PersonController : Controller
    {

        static List<Person> people = new List<Person>(); // Lab4.3(3)5 список объектов Person

        // GET: PersonController         
        public ActionResult Index() // Lab4.3(3)4 методы действий для HTTP GET
        {
            // Lab4.3(4)9 п.к.м. Index. Добавить представление

            //return View();
            return View(people); // Lab4.3(3)7 передайте в представление список объектов people
        }

        // GET: PersonController/Details/5
        public ActionResult Details(Person p) // Lab4.3(3)4 методы действий для HTTP GET
        {
            // Lab4.3(6)1 п.к.м. Details. Добавить представление
            // Lab4.3(6)4 принимал в качестве параметра объект типа Person и передавал этот объект в представление. (Person p) (p)

            //return View();
            return View(p);
        }

        // GET: PersonController/Create
        public ActionResult Create() // Lab4.3(3)4 методы действий для HTTP GET
        {
            // Lab4.3(5)1 п.к.м. Create. Добавить представление

            return View();
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        /* Lab4.3(5)3 замените метод действия Create
        public ActionResult Create(IFormCollection collection) // Lab4.3(3)4 методы действий для HTTP POST
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
        // Lab4.3(5)3 замените метод действия Create
        public ActionResult Create(Person p)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create", p);
                }

                people.Add(p);

                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Edit/5
        public ActionResult Edit(int id) // Lab4.3(3)4 методы действий для HTTP GET
        {
            // Lab4.3(8)2 замените метод действия Edit
            //return View();
            Person p = new Person();
            foreach (Person pn in people)
            {
                if (pn.Id == id)
                {
                    p.Name = pn.Name;
                    p.Age = pn.Age;
                    p.Id = pn.Id;
                    p.Phone = pn.Phone;
                    p.Email = pn.Email;
                }
            }
            return View(p);

            // Lab4.3(8)3 п.к.м. Edit. Добавить представление
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        /* Lab4.3(8)2 замените метод действия Edit
        public ActionResult Edit(int id, IFormCollection collection) // Lab4.3(3)4 методы действий для HTTP POST
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
        public ActionResult Edit(Person p)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", p);
            }

            foreach (Person pn in people)
            {
                if (pn.Id == p.Id)
                {
                    pn.Name = p.Name;
                    pn.Age = p.Age;
                    pn.Id = p.Id;
                    pn.Phone = p.Phone;
                    pn.Email = p.Email;
                }
            }

            return RedirectToAction("Index");
        }

        // GET: PersonController/Delete/5
        public ActionResult Delete(int id) // Lab4.3(3)4 методы действий для HTTP GET
        {
            // Lab4.3(7)2 п.к.м. Delete. Добавить представление

            // Lab4.3(7)4 замените метод действия Delete
            //return View();
            Person p = new Person();
            foreach (Person pn in people)
            {
                if (pn.Id == id)
                {
                    p.Name = pn.Name;
                    p.Age = pn.Age;
                    p.Id = pn.Id;
                    p.Phone = pn.Phone;
                    p.Email = pn.Email;

                    return View(p);
                }
            }

            return RedirectToAction("Index");
        }

        // POST: PersonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        /*  Lab4.3(7)5 замените метод действия Delete
        public ActionResult Delete(int id, IFormCollection collection) // Lab4.3(3)4 методы действий для HTTP POST
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
        public ActionResult Delete(Person p)
        {
            try
            {
                // TODO: Add delete logic here
                foreach (Person pn in people)
                {
                    if (pn.Id == p.Id)
                    {
                        people.Remove(pn);
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
