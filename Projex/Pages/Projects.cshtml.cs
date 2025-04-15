using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projex.Models;

namespace Projex.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<Project> Projects { get; set; }

        public void OnGet()
        {
            // Заглушка с данными
            Projects = new List<Project>
            {
                new Project { Id = 1, Name = "Проект 1", Description = "Описание проекта 1" },
                new Project { Id = 2, Name = "Проект 2", Description = "Описание проекта 2" },
                new Project { Id = 3, Name = "Проект 3", Description = "Описание проекта 3" }
            };
        }
    }
}
