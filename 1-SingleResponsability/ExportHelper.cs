﻿using System.Text;

namespace SingleResponsability
{
    public class ExportHelper
    {

        public void Export(IEnumerable<Student> students)
        {
            string studentsFile = String.Join(",", students.Select(x => x.ToString()).ToArray());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("Id;Fullname;Grades");
            foreach (var item in students)
            {
                sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
            }
            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(),Encoding.Unicode);
        }


    }

}