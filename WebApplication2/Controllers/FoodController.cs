using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{


    public class FoodController : Controller
    {
        // GET: ChineseFood

       

        dbYusandyShoppingCarEntities db = new dbYusandyShoppingCarEntities();


        public ActionResult BakeFood()
        {
            var bfcarrige = db.BakeFood.OrderByDescending(m => m.Id).ToList(); 

            return View(bfcarrige);
        }

        public ActionResult ChineseFood()
        {
            var cfcarrige = db.ChineseFood.OrderByDescending(m => m.Id).ToList();  //將"ChineseFoodCarrige"資料表中的商品欄位"cfProduct"指派給變數" cfcarrige"

            return View(cfcarrige);
        }

        public ActionResult ColubiaFood()
        {
            var clfcarrige = db.ColubiaFood.OrderByDescending(m => m.Id).ToList();  //將"ChineseFoodCarrige"資料表中的商品欄位"cfProduct"指派給變數" cfcarrige"

            return View(clfcarrige);
        }

        public ActionResult Drink()
        {
            var drink = db.Drink.OrderByDescending(m => m.Id).ToList();  //將"ChineseFoodCarrige"資料表中的商品欄位"cfProduct"指派給變數" cfcarrige"

            return View(drink);
        }


        public ActionResult FranceFood()
        {
            var ffcarrige = db.FranceFood.OrderByDescending(m => m.Id).ToList();  //將"ChineseFoodCarrige"資料表中的商品欄位"cfProduct"指派給變數" cfcarrige"

            return View(ffcarrige);
        }

        public ActionResult JapaneseFood()
        {
            var jfcarrige = db.JapaneseFood.OrderByDescending(m => m.Id).ToList();  //將"ChineseFoodCarrige"資料表中的商品欄位"cfProduct"指派給變數" cfcarrige"

            return View(jfcarrige);
        }

        public ActionResult SkinFood()
        {
            var sfcarrige = db.SkinFood.OrderByDescending(m => m.Id).ToList();  //將"ChineseFoodCarrige"資料表中的商品欄位"cfProduct"指派給變數" cfcarrige"

            return View(sfcarrige);
        }



        public ActionResult OldFood()
        {
            var ofcarrige = db.OldFood.OrderByDescending(m => m.Id).ToList();  //將"ChineseFoodCarrige"資料表中的商品欄位"cfProduct"指派給變數" cfcarrige"

            return View(ofcarrige);
        }

        public ActionResult ThiFood()
        {
            var thfcarrige = db.ThiFood.OrderByDescending(m => m.Id).ToList();  //將"ChineseFoodCarrige"資料表中的商品欄位"cfProduct"指派給變數" cfcarrige"

            return View(thfcarrige);
        }


    }
}