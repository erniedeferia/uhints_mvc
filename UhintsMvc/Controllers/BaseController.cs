using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using UhintsMvc.Models;
using UhintsMvc.DataAccess;

namespace UhintsMvc.Controllers
{
    public class BaseController : Controller
    {
        protected readonly UnifiedhintsEntities repository;

        public BaseController(DbContext repo)
        {
            this.repository = (UnifiedhintsEntities)repo;
        }
    }
}