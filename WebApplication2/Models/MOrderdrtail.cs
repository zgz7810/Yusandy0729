using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class MOrderdrtail
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("訂單編號")]
        public string OrderGuid { get; set; }

        [DisplayName("會員帳號")]
        public string mAccount { get; set; }

        [DisplayName("產品編碼")]
        public string PId { get; set; }

        [DisplayName("品名")]
        public string Name { get; set; }

        [DisplayName("商品種類")]
        public string Kind { get; set; }

        [DisplayName("單價")]
        public string Price { get; set; }

        [DisplayName("訂購數量")]
        public Nullable<int> Qty { get; set; }

        [DisplayName("是否為訂單")]
        public string IsApproved { get; set; }
    }
}