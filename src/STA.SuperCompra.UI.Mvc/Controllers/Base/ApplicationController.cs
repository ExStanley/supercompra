using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STA.SuperCompra.UI.Mvc.Controllers.Base
{

    public class ApplicationController //: Controller where T : class
    {
        //protected ApplicationRepository Repository { get; set; }
        //private string[] _strLockedProperties = new string[] {
        //    "Id",
        //    "CreatedOn",
        //    "CreatedBy",
        //    "ModifiedOn",
        //    "ModifiedBy"
        //};

        //protected virtual string[] LockedProperties
        //{
        //    get
        //    {
        //        return _strLockedProperties;
        //    }
        //}

        //public ApplicationController()
        //{
        //    Repository = new ApplicationRepository();
        //}

        //public virtual ActionResult Index()
        //{
        //    return View(Repository.GetAll());
        //}

        //public virtual ActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public virtual ActionResult Create(T record)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Repository.Insert(record);
        //        Repository.Save();
        //    }

        //    return RedirectToAction("Index");
        //}

        //public virtual ActionResult Details(Guid id)
        //{
        //    return View(Repository.Get(id));
        //}

        //public virtual ActionResult Edit(Guid id)
        //{
        //    return View(Repository.Get(id));
        //}

        //[HttpPost]
        //public virtual ActionResult Edit(Guid id, T record)
        //{
        //    var properties = typeof(T).GetProperties();
        //    var fields = new List();
        //    foreach (var prop in properties)
        //    {
        //        if (!LockedProperties.Contains(prop.Name))
        //        {
        //            fields.Add(prop.Name);
        //        }
        //    }
        //    var allowed = fields.ToArray();
        //    var existing = Repository.Get(id);

        //    if (TryUpdateModel(existing, allowed))
        //    {
        //        Repository.Save();
        //        return RedirectToAction("Index");
        //    }

        //    return View(record);
        //}

        //public virtual ActionResult Delete(Guid id)
        //{
        //    return View(Repository.Get(id));
        //}

        //[HttpPost]
        //public virtual ActionResult Delete(Guid id, string confirm)
        //{
        //    Repository.Delete(Repository.Get(id));
        //    Repository.Save();

        //    return RedirectToAction("Index");
        //}
    }
}