using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCvWebsite.Models
{
    public class DataManager
    {
        static List<Project> projects = new List<Project>
        {
            new Project{Period="Jan 2017 - Juni 2017", Company="Tekniska Verken AB", Type="Exjobb", WorkDescription="Undersökte tekniska och marknadsmässiga möjligheter för produktion av flytande biogas."}

        };

        public static Project GetAProject(int id)
        {
            return projects[id];
        }

        public static List<Project> GetAllProject()
        {
            return projects;
        }
    }
}
