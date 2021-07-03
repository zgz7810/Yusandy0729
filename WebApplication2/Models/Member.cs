using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Member
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("帳號")]
        [Required]
        public string mAccount { get; set; }

        [DisplayName("密碼")]
        [Required]
        public string mPasswd { get; set; }

        [DisplayName("姓名")]
        [Required]
        public string mFName { get; set; }

        [DisplayName("性別")]
        [Required]
        public string mSex { get; set; }

        [DisplayName("電話")]
        [Required]
        public string mPhone { get; set; }

        [DisplayName("生日")]
        [Required]
        public Nullable<System.DateTime> mBirthday { get; set; }

        [DisplayName("信箱")]
        [Required]
        public string mEmail { get; set; }


        [DisplayName("地址")]
        [Required]
        public string mAddress { get; set; }
    }
}