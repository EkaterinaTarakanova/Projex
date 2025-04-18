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
            // �������� � �������
            Projects = new List<Project>
            {
                new Project { Id = 1, Name = "������ 1", Description = "�������� ������� 1" },
                new Project { Id = 2, Name = "������ 2", Description = "�������� ������� 2" },
                new Project { Id = 3, Name = "������ 3", Description = "�������� ������� 3" }
            };
        }
    }
}
