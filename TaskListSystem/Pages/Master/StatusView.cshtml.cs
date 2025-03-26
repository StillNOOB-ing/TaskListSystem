using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskListSystem.Database;
using TaskListSystem.Database.Model;

using TaskListSystem.Database.Interface;

namespace TaskListSystem.Pages
{
    public class StatusViewModel : PageModel
    {
        private readonly IMasterHelper masterHelper;
        private readonly ILogger<IndexModel> _logger;

        public StatusViewModel(IMasterHelper mHelper, ILogger<IndexModel> logger)
        {
            masterHelper = mHelper;
            _logger = logger;
        }

        public List<MStatus> StatusList { get; set; } = new List<MStatus>();

        public async Task OnGetAsync()
        {
            StatusList = await masterHelper.GetStatusAll();
        }

        public async Task OnAddClick()
        {

        }

        public async Task OnEditClick(MStatus item)
        {

        }

        public async Task OnDeleteClick(MStatus item)
        {

        }
    }
}
