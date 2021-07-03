using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class MOrder
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("訂單編號")]
        public string OrderGuid { get; set; }

        [DisplayName("會員帳號")]
        public string mAccount { get; set; }

        [DisplayName("收件人姓名")]
        public string Receiver { get; set; }

        [DisplayName("收件人信箱")]
        public string Email { get; set; }

        [DisplayName("收件人地址")]
        public string Addfess { get; set; }

        [DisplayName("收件人電話")]
        public string Phone { get; set; }

        [DisplayName("訂單日期")]
        public Nullable<System.DateTime> Date { get; set; }
    }
}