using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Manager : Employee
    {
        public Manager(string name, ICollection<string> documents) : base(name)
        {
            this.Documents = new List<string>(documents);
        }
        public IReadOnlyCollection<string> Documents { get; }

        public override string GetDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.GetDetails());
            sb.AppendLine($"{string.Join(", ", Documents)}");
            return sb.ToString().TrimEnd();
        }
    }
}
