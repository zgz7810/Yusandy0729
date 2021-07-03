using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebApplication2.Models
{
    public class Kind
    {
        
        [Key]
        public string Id { get; set; }  //圖片編號屬性
        public string Name { get; set; }  //料理類別屬性
        public string Url { get; set; }  //連結屬性
    }
}