using DefaultModelBinderForN00bs.Models;
using DefaultModelBinderForN00bs.Models.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DefaultModelBinderForN00bs.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Edit()
        {
            var vm = new PersonViewModel
            {
                Id = 1,
                Name = "Jane Doe",
                Friend = new Person
                {
                    Id = 2,
                    Name = "Jon Doe"
                },
                Addresses = new Address[]
                {
                    new Address
                    {
                        Id = 1,
                        City = "Athens",
                        State = "Texas"
                    },
                    new Address
                    {
                        Id = 2,
                        City = "Paris",
                        State = "Texas"
                    }
                }
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(PersonViewModel vm)
        {
            return View("Details", vm);
        }
    }
}
