using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UhintsMvc.Models;
using System.Data.Entity;
using UhintsMvc.Dynamic;

namespace UhintsMvc.Controllers
{
    public class MedicalHistoryController : BaseController
    {

        private readonly long userId = 50121;
        protected readonly TableDescriptor tableMeta = new TableDescriptor( 
            new KeyField("ailment_id", "ID") , 
            new Field("ailment_name", "Name"),
            new Field("ailment_nickname", "Nickname"),
            new Field("ailment_start_dt","Start Date"), 
            new Field("ailment_end_dt","End Date"),
            new ActionField() { DeletAction = "delete"});

        public MedicalHistoryController(DbContext c) : base(c)
        {

        }

        // GET: MedicalHistory
        public ActionResult Index()
        {
            ViewBag.TableDescriptor = this.tableMeta;
            ViewBag.Records = MedicalHistory.Records(this.repository, userId);

            return View();
        }

        // GET: MedicalHistory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MedicalHistory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicalHistory/Create
        [HttpPost]
        public ActionResult Create(MedicalHistory m)
        {

            try
            {
                var result = m.Create(this.repository);

                return RedirectToAction("Index");
            }
            catch( Exception e )
            {
                string msg = e.Message;

                return View();
            }
        }

        // GET: MedicalHistory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MedicalHistory/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MedicalHistory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MedicalHistory/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
