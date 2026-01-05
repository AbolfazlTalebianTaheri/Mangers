using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manger
{
    internal static class DgvExtentions
    {
        public static void BuildColumns<T>(this DataGridView dgv)
        {
            var properties = typeof(T).GetProperties();
            dgv.Columns.Clear();
            foreach (var property in properties)
            {
                var attr = property.GetCustomAttribute<CostomAttribute>(true);
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = property.Name,
                    HeaderText = attr == null ? property.Name : attr.DisplayName,
                    Name = property.Name,
                });
                    dgv.Columns[property.Name].Visible = attr !=null;
              
            }
        }
    }
}
