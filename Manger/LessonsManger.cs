using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manger
{
    public class LessonsManger
    {
        public static List<Lessons> GetLessons()
        {
            return new List<Lessons>()
            {
                new Lessons {Lesson = "ریاضی",Teacher = "اکبری" ,Id =1 },
                new Lessons {Lesson = "فارسی",Teacher ="احمدی" ,Id =2 },
                new Lessons {Lesson = "عربی",Teacher="اصغری" ,Id =3 }
            };
        }
    }
}
