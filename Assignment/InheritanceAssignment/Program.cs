using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text(100);
            System.Console.WriteLine($"Height : {text.Height}");
            text.HyperLink("mypic.jpeg");
            text.Duplicate();
        }
    }
}
