using System;
namespace BeehiveNews.BL
{
	public interface IWebParse
	{
		String getContentFromHtml();

		String getImageUrl();
	}
}

