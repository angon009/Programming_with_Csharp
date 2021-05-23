using System;
using System.Text;


namespace Appends
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();

            text.Append('-', 6);
            text.Append("Dev Skill");
            text.Append('-', 6);

            text.AppendLine(); // For new Line

            text.Append("Paragraph will start from here ");
            text.Append('.', 20);

            text.Replace("Paragraph" , "Writings");
            text.Replace('.', '_');

            text.AppendLine();

            text.Append("Angon Chowdhury, ");
            text.Append("Department of CSE , ");
            text.Append("International Islamic University Chittagong , ");
            text.Append(Console.ReadLine() + " , ");

            text.Append("Due : ");
            text.AppendFormat("{0:C}", 500);

            text.AppendLine();

            text.Append("Subject List : ").Append('-').AppendLine().Append("1.Data Structure").AppendLine().Append("2.Algorithm").AppendLine().Append("3.Object Oriented Programming").Append(" and many more").Append('.',10);

            Console.WriteLine(text);

            
        }
    }
}
