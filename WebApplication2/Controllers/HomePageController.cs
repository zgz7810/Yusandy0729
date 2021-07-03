using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using System.Web.Security;

namespace WebApplication2.Controllers
{
    public class HomePageController : Controller
    {
        dbYusandyShoppingCarEntities db = new dbYusandyShoppingCarEntities();

        // GET: Home

        //首頁
        public ActionResult Home()
        {
            return View();  
        }


        //商品選擇頁面
        public ActionResult CarrigeView()
        {
            List<Kind> kinds = new List<Kind>(); //建立料理類別清單
            kinds.Add(new Kind { Id = "cf", Name = "中式料理", Url = "ChineseFood" });  //把"中式料理"加入清單
            kinds.Add(new Kind { Id = "Ff", Name = "法式料理", Url = "FranceFood" });  //把"法式料理"加入清單
            kinds.Add(new Kind { Id = "Jf", Name = "日式料理", Url = "JapaneseFood" });  //把"日式料理"加入清單
            kinds.Add(new Kind { Id = "Thf", Name = "泰式料理", Url = "ThiFood" });  //把"泰式料理"加入清單
            kinds.Add(new Kind { Id = "clf", Name = "加勒比海料理", Url = "ColubiaFood" });  //把"加勒比海料理"加入清單
            kinds.Add(new Kind { Id = "of", Name = "古早味料理", Url = "OldFood" });  //把"古早味"加入清單
            kinds.Add(new Kind { Id = "sf", Name = "健身減脂料理", Url = "SkinFood" });  //把"健身減脂理"加入清單
            kinds.Add(new Kind { Id = "bf", Name = "烘焙料理", Url = "BakeFood" });  //把"烘焙料理"加入清單
            kinds.Add(new Kind { Id = "d", Name = "飲料", Url = "Drink" });  //把"飲料"加入清單

            return View(kinds);  //顯示kinds清單
        }


        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string mAccount, string mPasswd)
        {
            var member = db.MemberData.Where(m => m.mAccount == mAccount && m.mPasswd == mPasswd).FirstOrDefault();
           
            //會員資料尚未建立
            if(member == null)
            {
                ViewBag.Message = "帳密錯誤，登入失敗";
                return View();
            }

            Session["WelCome"] = "哈囉!" + "" +member.mAccount;

            FormsAuthentication.RedirectFromLoginPage(mAccount, true);
            return RedirectToAction("Home", "HomePage");

        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(MemberData pMember)
        {
            if(ModelState.IsValid == false)
            {
                return View();
            }
            var member = db.MemberData.Where(m => m.mAccount == pMember.mAccount).FirstOrDefault();
            if (member == null)
            {
                db.MemberData.Add(pMember);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            ViewBag.Message = "此帳號已經被註冊，請更換另一個帳號名稱";
            return View();

           
        }
   }
}