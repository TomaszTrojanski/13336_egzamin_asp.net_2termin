using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _13336_egzamin_asp.net_2termin.Models;

namespace _13336_egzamin_asp.net_2termin.Controllers
{
    public class TaskController : Controller
    {
        private static IList<TaskModel> tasks = new List<TaskModel>()
        {
            new TaskModel(){IdTask = 1, Name = "Przykładowe zadanie", Opis = "Opis zadania",DataUtworzenia = "23.02.2022",TerminWykonania = "",JobDone = false}
        };
        // GET: TaskController
        public ActionResult Index()
        {
            return View(tasks);
        }

        // GET: TaskController/Details/5
        public ActionResult Details(int id)
        {
            return View(tasks.FirstOrDefault((x =>x.IdTask==id)));
        }

        // GET: TaskController/Create
        public ActionResult Create()
        {
            return View(new TaskModel());
        }

        // POST: TaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaskModel taskModel)
        {
            taskModel.IdTask = tasks.Count + 1;
            tasks.Add(taskModel); 
            return RedirectToAction(nameof(Index));
        }

        // GET: TaskController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(tasks.FirstOrDefault(x=>x.IdTask == id));
        }

        // POST: TaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TaskModel taskModel)
        {
            TaskModel task = tasks.FirstOrDefault(x => x.IdTask == id);
            task.Name = taskModel.Name;
            task.Opis = taskModel.Opis;
            return RedirectToAction(nameof(Index));
        }
        //GET: JOBDONE
        public ActionResult JobDone(int id)
        {
            TaskModel task = tasks.FirstOrDefault(x => x.IdTask == id);
            task.JobDone = true;

            return RedirectToAction(nameof(Index));


        }
    }
}
