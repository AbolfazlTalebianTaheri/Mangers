using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manger
{
    public static class Messages
    {
        public static string NationalDode
        {
            get
            {
               return "کد ملی را وارد کنید";
            }
        }
        public static string Success
        {
            get
            {
                return "ثبت موفقیت با مو فقیت انجام شد";
            }
        }
        public static string FirstName
        {
            get
            {
                return "کادر نام پر کنید";
            }
        }
        public static string LastName
        {
            get
            {
                return "کادر نام خوانوادگی را پرکنید";
            }
        }
        public static string Location
        {
            get
            {
                return "آدرس خود را درست وارد کنید";
            }
        }
        public static string PhoneNumber
        {
            get
            {
                return "شماره همراه خود را وارد کنید";
            }
        }
    }
}
