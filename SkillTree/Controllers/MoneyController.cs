using SkillTree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillTree.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult List()
        {
            List<Money> MoneyList = new List<Money>();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                MoneyList.Add(
                    new Money()
                    {
                        Amount = rand.Next() % 1000000,
                        Category = (i % 3 == 0 ? "提款" : "存入"),
                        Date = DateTime.Now.AddDays(rand.Next() % 30)
                    }
                );
            }
            return View(MoneyList.OrderBy(p => p.Category).ToList());
        }
    }
}