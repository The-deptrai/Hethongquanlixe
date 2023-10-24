/*using System;
using PagedList;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hethongquanlixe.Context;
using static Hethongquanlixe.Common;
using EntityState = System.Data.Entity.EntityState;
using Hethongquanlixe.Models;

namespace Hethongquanlixe.Areas.Admin.Controllers
{
    
        public class YeuCauController : Controller
{
        HethongquanlithuexeEntities objHethongquanlithuexeEntities = new HethongquanlithuexeEntities();
        // GET: Admin/Product
        *//* public ActionResult Index(string SearchString)
         {
             var lstProduct = objQuanlibanhangEntities3.tb_Product.Where(n => n.Name.Contains(SearchString)).ToList();
             return View(lstProduct);
         }*//*

        public ActionResult Index(string CurrentFilter, string SearchString, int? page)
        {
            var LYeuCau = new List<YeuCau>();
            *//*AdminModel objAdminModel = new AdminModel();*/
            /* objAdminModel.LProduct = objQuanlibanhangEntities3.tb_Product.ToList();
             objAdminModel.LCategory = objQuanlibanhangEntities3.tb_Category.ToList();

             return View(objAdminModel);*//*
            if (SearchString != null)
            {
                page = 1;
            }
            else
            {
                SearchString = CurrentFilter;
            }
            if (!string.IsNullOrEmpty(SearchString))
            {
                *//*LYeuCau = objHethongquanlithuexeEntities.YeuCau.Where(n => n.Ten.Contains(SearchString)).ToList();*//*
                LYeuCau = objHethongquanlithuexeEntities.
            }
            else
            {
                LYeuCau = objHethongquanlithuexeEntities.YeuCau.ToList();
            }
            ViewBag.CurrentFilter = SearchString;
            int pageSize = 4;
            int pageNumber = (page ?? 1);
            LYeuCau = LYeuCau.OrderByDescending(n => n.Id).ToList();
            return View(LYeuCau.ToPagedList(pageNumber, pageSize));
        }
        //DETAIL
        public ActionResult Details(int Id)
        {
            var objProduct = objHethongquanlithuexeEntities.tb_Product.Where(n => n.Id == Id).FirstOrDefault();
            return View(objProduct);
        }

        [HttpGet]
        public ActionResult Create()
        {

            this.LoadData();
            return View();
        }


        [HttpPost]
        public ActionResult Create(tb_Product objProduct)
        {
            this.LoadData();
            if (ModelState.IsValid)
            {
                try
                {
                    if (objProduct.ImageUpload != null)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(objProduct.ImageUpload.FileName);

                        string extension = Path.GetExtension(objProduct.ImageUpload.FileName);

                        fileName = fileName + extension;

                        objProduct.Avatar = fileName;
                        objProduct.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/Content/images/items"), fileName));
                    }
                    objProduct.CreatedOnUtc = DateTime.Now;
                    objHethongquanlithuexeEntities.tb_Product.Add(objProduct);
                    objHethongquanlithuexeEntities.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            return View(objProduct);
        }

        void LoadData()
        {
            Common objcommon = new Common();

            var lstCat = objHethongquanlithuexeEntities.tb_Category.ToList();

            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            DataTable dtCategory = converter.ToDataTable(lstCat);
            ViewBag.ListCategory = objcommon.ToSelectList(dtCategory, "Id", "Name");

            var lstBrand = objHethongquanlithuexeEntities.tb_Brand.ToList();
            DataTable dtBrand = converter.ToDataTable(lstBrand);
            ViewBag.ListBrand = objcommon.ToSelectList(dtBrand, "Id", "Name");


            List<ProductType> lstProductType = new List<ProductType>();
            ProductType objProductType = new ProductType();
            objProductType.Id = 01;
            objProductType.Name = "Giam gia cuc soc";
            lstProductType.Add(objProductType);

            objProductType = new ProductType();
            objProductType.Id = 02;
            objProductType.Name = "Gia de xuat";
            lstProductType.Add(objProductType);

            DataTable dtProductType = converter.ToDataTable(lstProductType);
            ViewBag.ProductType = objcommon.ToSelectList(dtProductType, "Id", "Name");
        }


        //EDIT
        [HttpGet]
        public ActionResult Edit(int id)
        {

            var objProduct = objHethongquanlithuexeEntities.tb_Product.Where(n => n.Id == id).FirstOrDefault();
            return View(objProduct);
        }

        [HttpPost]
        public ActionResult Edit(tb_Product objProduct)
        {

            if (objProduct.ImageUpload != null)
            {
                string fileName = Path.GetFileNameWithoutExtension(objProduct.ImageUpload.FileName);

                string extension = Path.GetExtension(objProduct.ImageUpload.FileName);

                fileName = fileName + extension;

                objProduct.Avatar = fileName;
                objProduct.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/Content/images/items"), fileName));
            }
            *//*objQuanlibanhangEntities3.Entry(objProduct).State = EntityState.Modified;*//*
            objHethongquanlithuexeEntities.Entry(objProduct).State = EntityState.Modified;
            objHethongquanlithuexeEntities.SaveChanges();
            return View(objProduct);
        }

        //delete

        [HttpGet]
        public ActionResult Delete(int id)
        {

            var objProduct = objHethongquanlithuexeEntities.tb_Product.Where(n => n.Id == id).FirstOrDefault();
            return View(objProduct);
        }

        [HttpPost]
        public ActionResult Delete(tb_Product objPro)
        {

            var objProduct = objHethongquanlithuexeEntities.tb_Product.Where(n => n.Id == objPro.Id).FirstOrDefault();
            objHethongquanlithuexeEntities.tb_Product.Remove(objProduct);
            objHethongquanlithuexeEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
}*/