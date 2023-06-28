
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Models;

namespace UmbracoProject.Models

{

	public class ImageSectionModel : ContentModel
	{

		
		public ImageSectionModel(IPublishedContent content) : base(content)
		{
		}

		public IPublishedContent MainImage => this.Value<IPublishedContent>("mainImage");

		
		
	}
}
