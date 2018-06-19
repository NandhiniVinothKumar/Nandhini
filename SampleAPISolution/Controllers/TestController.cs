using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleAPISolution.Models;

namespace SampleAPISolution.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        TestAPIController testapidata = new TestAPIController();
        List<TestData> data = new List<TestData>();

        public ActionResult Index()
        {
               data= testapidata.Get();

            return View("Index",data);
        }

        // GET: Test/Details/5
        [ActionName("GetDataByID")]
        public ActionResult Details(string id)
        {
            TestData data = new TestData();
            data = testapidata.Get(id);
            return View("Details", data);
        }

        // GET: Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        [HttpPost]
        public ActionResult Create(TestData data)
        {
            try
            {
                // TODO: Add insert logic here
                testapidata.Post(data);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Test/Edit/
        public ActionResult Edit(string id)
        {
            TestData data = new TestData();
            data = testapidata.Get(id);
            return View(data);
        }

        // POST: Test/Edit/
        [HttpPost]
        public ActionResult Edit(string id, TestData data)
        {
            try
            {
                // TODO: Add update logic here
                testapidata.Put(id, data);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Test/Delete/
        public ActionResult Delete(string id)
        {
            TestData data = new TestData();
            data = testapidata.Get(id);
            return View(data);
        }

        // POST: Test/Delete/
        [HttpPost]
        public ActionResult Delete(string id, TestData data)
        {
            try
            {
                // TODO: Add delete logic here
                testapidata.Delete(id, data);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
