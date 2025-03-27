using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskListSystem.Database;
using TaskListSystem.Database.Model;

using TaskListSystem.Database.Interface;
using Microsoft.AspNetCore.Http.HttpResults;

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

        public async Task<IActionResult> OnGetAsync()
        {
            StatusList = await masterHelper.GetStatusAll();

            return Page();
        }

        public async Task<IActionResult> OnPostEditStatus([FromBody] MStatus item)
        {
            var result = await masterHelper.UpdateStatus(item);

            if (result.success)
            {
                return new JsonResult(new { result.success, result.message });
            }

            return new JsonResult(new { result.success, result.message });
        }

        public async Task<IActionResult> OnGetDeleteClick(int id)
        {
            var item = await masterHelper.GetStatusByID(id);

            if (item != null)
            {
                var result = await masterHelper.DeleteStatus(item);

                if (result.success)
                {
                    return RedirectToPage("StatusView");
                }
                else
                {
                    return BadRequest(new { result.success, result.message });
                }
            }
           
            return NotFound(new { success = false, message = "Not Found"});
        }
    }
}
