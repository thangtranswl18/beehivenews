using System;

using Microsoft.Maui.Controls.Compatibility;

using BeehiveNews;
using BeehiveNews.Platforms.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(ButtonRenderer), typeof(iOSButtonRenderer))]
namespace BeehiveNews.Platforms.iOS.CustomRenderers
{
	public class iOSButtonRenderer
	{
		public iOSButtonRenderer()
		{
		}
	}
}

