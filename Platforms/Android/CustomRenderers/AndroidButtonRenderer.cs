using System;
using BeehiveNews;
using BeehiveNews.Platforms.Android.CustomRenderers;
using Microsoft.Maui.Controls.Compatibility;

[assembly: ExportRenderer(typeof(ButtonRenderer), typeof(AndroidButtonRenderer))]
namespace BeehiveNews.Platforms.Android.CustomRenderers
{
	public class AndroidButtonRenderer : ButtonRenderer
	{
		public AndroidButtonRenderer(AppContext context) : base(context)
		{
		}
	}
}

