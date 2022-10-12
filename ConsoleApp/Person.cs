using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp;

internal class Person
{
    public string Name { get; set; } = null!;
    public string? Surname { get; set; }
    public string? Patronymic { get; set; }

    public string? Prefix { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public override string ToString()
    {
        void AppendItem(StringBuilder sb, string? item)
        {
            if (!String.IsNullOrEmpty(item))
            {
                if (sb.Length > 0) sb.Append(" ");
                sb.Append(item);
            }
        }

        void AppendLine(StringBuilder sb, string? desc, string? item)
        {
            if (!String.IsNullOrEmpty(item))
            {
                sb.Append("\r\n");
                if (!string.IsNullOrEmpty(desc))
                {
                    sb.Append(desc);
                    sb.Append(" ");
                    sb.Append(item);
                }
                else
                    sb.Append(item);
            }
        }

        StringBuilder sb = new StringBuilder();
        AppendItem(sb, Prefix);
        AppendItem(sb, Name);
        AppendItem(sb, Patronymic);
        AppendItem(sb, Surname);
        AppendLine(sb, "Email:", Email);
        AppendLine(sb, "Phone:", Phone);

        return sb.ToString();
    }
}
