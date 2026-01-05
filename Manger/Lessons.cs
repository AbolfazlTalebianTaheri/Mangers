using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manger
{
    public class Lessons
    {
        public int Id {  get; set; }
        [CostomAttribute("نام درس")]
        public string Lesson {  get; set; }
        [CostomAttribute("نام معلم")]
        public string Teacher { get; set; }

    }
}
