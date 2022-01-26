using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProject
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new EmployeeManager());
        }


    }
}
