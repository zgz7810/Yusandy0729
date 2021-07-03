using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    //下拉式選單模組
    public class CarrigeChoose
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}