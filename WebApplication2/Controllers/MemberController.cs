using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using System.Web.Security;

namespace WebApplication2.Controllers
{
    [Authorize]
    public class MemberController : Controller
    {       
        dbYusandyShoppingCarEntities db = new dbYusandyShoppingCarEntities();
      
 

        //會員將商品加入購物車
        public ActionResult Shopping()
        {
            //var products = db.ShoppinCar.OrderByDescending(m => m.Id).ToString();
            return View("../HomePage/Home", "_LayoutMember");
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "HomePage");
        }

        //顯示購物車
        public ActionResult ShoppingCar()
        {
            string mAccount = User.Identity.Name;
            var orderDetails = db.Orderdetail.Where(m => m.mAccount == mAccount && m.IsApproved == "否").ToList();
            return View(orderDetails);
        }

        //加入購物車
        public ActionResult AddCar(string PId)
        {
            string mAccount = User.Identity.Name;
            var SC = db.Orderdetail.Where(m=>m.PId == PId &&  m.IsApproved == "否" && m.mAccount == mAccount).FirstOrDefault();
            
            if (SC == null)
            {
                var product = db.ChineseFood.Where(m => m.PId == PId).FirstOrDefault();
                
                Orderdetail od = new Orderdetail();
               
                od.mAccount = mAccount;
                od.PId = product.PId;
                od.Name = product.Name;
                od.Kind = product.FoodPacket;
                //od.Kind = product.DIY;
                od.Price = product.Price1;
               // od.Price = product.Price2;
                od.Qty = 1;
                od.IsApproved = "否";
                db.Orderdetail.Add(od);

            }
            else
            {
                SC.Qty += 1;
            }
            db.SaveChanges();
            return RedirectToAction("ShoppingCar");
        }
        public ActionResult AddCar1(string PId)
            {
            string mAccount = User.Identity.Name;
            var SB = db.Orderdetail.Where(m => m.PId == PId && m.IsApproved == "否" && m.mAccount == mAccount).FirstOrDefault();
            
            if (SB == null)
            {
                var product = db.BakeFood.Where(m => m.PId == PId).FirstOrDefault();
                Orderdetail od = new Orderdetail();

                od.mAccount = mAccount;
                od.PId = product.PId;
                od.Name = product.Name;
                od.Kind = product.FoodPacket;
                //od.Kind = product.DIY;
                od.Price = product.Price1;
                // od.Price = product.Price2;
                od.Qty = 1;
                od.IsApproved = "否";
                db.Orderdetail.Add(od);

            }
            else
            {
                SB.Qty += 1;
            }
            db.SaveChanges();

            return RedirectToAction("ShoppingCar");          
        }

        public ActionResult AddCar2(string PId)
        {
            string mAccount = User.Identity.Name;
            var SCL = db.Orderdetail.Where(m => m.PId == PId && m.IsApproved == "否" && m.mAccount == mAccount).FirstOrDefault();

            if (SCL == null)
            {
                var product = db.ColubiaFood.Where(m => m.PId == PId).FirstOrDefault();
                Orderdetail od = new Orderdetail();

                od.mAccount = mAccount;
                od.PId = product.PId;
                od.Name = product.Name;
                od.Kind = product.FoodPacket;
                //od.Kind = product.DIY;
                od.Price = product.Price1;
                // od.Price = product.Price2;
                od.Qty = 1;
                od.IsApproved = "否";
                db.Orderdetail.Add(od);

            }
            else
            {
                SCL.Qty += 1;
            }
            db.SaveChanges();

            return RedirectToAction("ShoppingCar");
        }

        public ActionResult AddCar3(string PId)
        {
            string mAccount = User.Identity.Name;
            var SD = db.Orderdetail.Where(m => m.PId == PId && m.IsApproved == "否" && m.mAccount == mAccount).FirstOrDefault();

            if (SD == null)
            {
                var product = db.Drink.Where(m => m.PId == PId).FirstOrDefault();
                Orderdetail od = new Orderdetail();

                od.mAccount = mAccount;
                od.PId = product.PId;
                od.Name = product.Name;
                od.Kind = product.FoodPacket;
                //od.Kind = product.DIY;
                od.Price = product.Price1;
                // od.Price = product.Price2;
                od.Qty = 1;
                od.IsApproved = "否";
                db.Orderdetail.Add(od);

            }
            else
            {
                SD.Qty += 1;
            }
            db.SaveChanges();

            return RedirectToAction("ShoppingCar");
        }

        public ActionResult AddCar4(string PId)
        {
            string mAccount = User.Identity.Name;
            var SF = db.Orderdetail.Where(m => m.PId == PId && m.IsApproved == "否" && m.mAccount == mAccount).FirstOrDefault();

            if (SF == null)
            {
                var product = db.FranceFood.Where(m => m.PId == PId).FirstOrDefault();
                Orderdetail od = new Orderdetail();

                od.mAccount = mAccount;
                od.PId = product.PId;
                od.Name = product.Name;
                od.Kind = product.FoodPacket;
                //od.Kind = product.DIY;
                od.Price = product.Price1;
                // od.Price = product.Price2;
                od.Qty = 1;
                od.IsApproved = "否";
                db.Orderdetail.Add(od);

            }
            else
            {
                SF.Qty += 1;
            }
            db.SaveChanges();

            return RedirectToAction("ShoppingCar");
        }

        public ActionResult AddCar5(string PId)
        {
            string mAccount = User.Identity.Name;
            var SJ = db.Orderdetail.Where(m => m.PId == PId && m.IsApproved == "否" && m.mAccount == mAccount).FirstOrDefault();

            if (SJ == null)
            {
                var product = db.JapaneseFood.Where(m => m.PId == PId).FirstOrDefault();
                Orderdetail od = new Orderdetail();

                od.mAccount = mAccount;
                od.PId = product.PId;
                od.Name = product.Name;
                od.Kind = product.FoodPacket;
                //od.Kind = product.DIY;
                od.Price = product.Price1;
                // od.Price = product.Price2;
                od.Qty = 1;
                od.IsApproved = "否";
                db.Orderdetail.Add(od);

            }
            else
            {
                SJ.Qty += 1;
            }
            db.SaveChanges();

            return RedirectToAction("ShoppingCar");
        }
        
        public ActionResult AddCar6(string PId)
        {
            string mAccount = User.Identity.Name;
            var SO = db.Orderdetail.Where(m => m.PId == PId && m.IsApproved == "否" && m.mAccount == mAccount).FirstOrDefault();

            if (SO == null)
            {
                var product = db.OldFood.Where(m => m.PId == PId).FirstOrDefault();
                Orderdetail od = new Orderdetail();

                od.mAccount = mAccount;
                od.PId = product.PId;
                od.Name = product.Name;
                od.Kind = product.FoodPacket;
                //od.Kind = product.DIY;
                od.Price = product.Price1;
                // od.Price = product.Price2;
                od.Qty = 1;
                od.IsApproved = "否";
                db.Orderdetail.Add(od);

            }
            else
            {
                SO.Qty += 1;
            }
            db.SaveChanges();

            return RedirectToAction("ShoppingCar");
        }

        public ActionResult AddCar7(string PId)
        {
            string mAccount = User.Identity.Name;
            var SS = db.Orderdetail.Where(m => m.PId == PId && m.IsApproved == "否" && m.mAccount == mAccount).FirstOrDefault();

            if (SS == null)
            {
                var product = db.SkinFood.Where(m => m.PId == PId).FirstOrDefault();
                Orderdetail od = new Orderdetail();

                od.mAccount = mAccount;
                od.PId = product.PId;
                od.Name = product.Name;
                od.Kind = product.FoodPacket;
                //od.Kind = product.DIY;
                od.Price = product.Price1;
                // od.Price = product.Price2;
                od.Qty = 1;
                od.IsApproved = "否";
                db.Orderdetail.Add(od);

            }
            else
            {
                SS.Qty += 1;
            }
            db.SaveChanges();

            return RedirectToAction("ShoppingCar");
        }

        public ActionResult AddCar8(string PId)
        {
            string mAccount = User.Identity.Name;
            var STH = db.Orderdetail.Where(m => m.PId == PId && m.IsApproved == "否" && m.mAccount == mAccount).FirstOrDefault();

            if (STH == null)
            {
                var product = db.ThiFood.Where(m => m.PId == PId).FirstOrDefault();
                Orderdetail od = new Orderdetail();

                od.mAccount = mAccount;
                od.PId = product.PId;
                od.Name = product.Name;
                od.Kind = product.FoodPacket;
                //od.Kind = product.DIY;
                od.Price = product.Price1;
                // od.Price = product.Price2;
                od.Qty = 1;
                od.IsApproved = "否";
                db.Orderdetail.Attach(od);
               

            }
            else
            {
                STH.Qty += 1;
            }
            db.SaveChanges();

            return RedirectToAction("ShoppingCar");
        }
        public ActionResult DeleteCar(int Id)
        {
            var od = db.Orderdetail.Where(m => m.Id == Id).FirstOrDefault();
            db.Orderdetail.Remove(od);
            db.SaveChanges();
            return RedirectToAction("ShoppingCar");

        }

        [HttpPost]
        public ActionResult ShoppingCar(string Receiver, string Email, string Address,string Phone)
        {
            string mAccount = User.Identity.Name;
            string guid = Guid.NewGuid().ToString();
            Order or = new Order();
            or.OrderGuid = guid;
            or.mAccount = mAccount;
            or.Receiver = Receiver;
            or.Email = Email;
            or.Addfess = Address;
            or.Phone = Phone;
            or.Date = DateTime.Now;
            db.Order.Add(or);
            

            var carList = db.Orderdetail.Where(m => m.IsApproved == "否" && m.mAccount == mAccount).ToList();

            foreach(var item in carList)
            {
                item.OrderGuid = guid;
                item.IsApproved = "是";
            }
            db.SaveChanges();
            return RedirectToAction("OrderList");
        }

        public ActionResult OrderList()
        {
            string mAccount = User.Identity.Name;
            var ors = db.Order.Where(m => m.mAccount == mAccount).OrderByDescending(m => m.Date).ToList();
            return View(ors);
        }

        public ActionResult OrdertDetail(string OrderGuid)
        {
            var odrs = db.Orderdetail.Where(m => m.OrderGuid == OrderGuid).ToList();
            return View(odrs);
        }

     
    }
}