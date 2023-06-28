using Microsoft.AspNetCore.Mvc;
using UmbracoProject.Models;

namespace UmbracoProject.Controllers
{
	public class QuoteFormController : Controller
	{
		[HttpPost]
		public IActionResult SubmitQuoteForm(QuoteFormModel model)
		{
			
			string name = model.Name;
			string email = model.Email;
			string phone = model.Phone;
			string company = model.Company;
			string projectDetails = model.ProjectDetails;
			string budget = model.Budget;
			string deadLine = model.DeadLine;
			string message = model.Message;

			return View();
		}

	}
}
