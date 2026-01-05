using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manger
{
    public class CostomAttribute : Attribute
    {
        public string DisplayName { get; }
        public CostomAttribute(string nameLesson)
        {
            DisplayName = nameLesson;
        }
    }
}
