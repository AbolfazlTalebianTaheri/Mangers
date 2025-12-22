using Manger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mnager
{
    public class StudentManager
    {
        private static List<Student> students;
        public StudentManager()
        {
            if (students == null)
                students = new List<Student>();
        }
        public IReadOnlyList<Student> GetAll()
        {
            return students;
        }
        public void Remove(int Index)
        {
            students.RemoveAt(Index);
        }
        public void Add(Student student)
        {
            students.Add(student);
        }
        public void Edit(Student student)
        {
            string firstName = student.FirstName;
            string lastName = student.LastName;
            var resultEdit= Duplicate(firstName, lastName);
            if(resultEdit.Index!=-1)
            students[resultEdit.Index] = student;
        }
        public OperatianResultEdit Duplicate(string firstName ,string lastName)
        {
            for (int i = 0; i < students.Count; i++)
                if (students[i].FirstName == firstName)
                    if (students[i].LastName == lastName)
                        return new OperatianResultEdit
                        {
                            IsSuccess =false,
                            Index = i,
                        };
            return new OperatianResultEdit
            {
                IsSuccess = true,
                Index = -1,
            };
        }
        public int Count()
        {
            return students.Count;
        }
    }
}
