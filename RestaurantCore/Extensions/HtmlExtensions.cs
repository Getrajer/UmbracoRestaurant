using System;
using System.Collections.Generic;
using System.Text;
using System.Web;


namespace RestaurantCore.Extensions
{
    public static class HtmlExtensions
    {
        public static IHtmlString GetGridHtml(this HtmlHelper html, IPublishedContent contentItem, string framework, string propertyAlias, bool fluidImages)
        {
            if (fluidImages)
            {
                return html.Raw(html.GetGridHtml(contentItem, framework, propertyAlias).ToString().Replace("<img ", "<img class=\"img-fluid\" "));
            }
            else
            {
                return html.GetGridHtml(contentItem, propertyAlias, framework);
            }
        }
    }
}
