using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Web.Common.PublishedModels;
using UmbracoProject.Models;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Common.Models;

namespace UmbracoProject.Controllers
{
	public class ImagePageController:  Controller
	{
		public IActionResult Index(ContentModel model)
		{
			var imagePageModel = new ImageSectionModel (model.Content);

			return View(imagePageModel);
		}
	}
}
