using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace CRM_for_English_School.Html_helpers
{
    public static class Buttons
    {
        public static HtmlString UseBadgedButton(this IHtmlHelper html, string label, string buttonStatus, int badgeValue, string badgeStatus, bool isDisabled)
        {
            if (html is null)
            {
                throw new ArgumentNullException(nameof(html));
            }

            string htmlCode = $"<button type=\"button\" class=\"btn btn-{buttonStatus} btn-sm position-relative\"";
            if (isDisabled)
                htmlCode += " disabled";
            htmlCode += $">{label}";
            htmlCode += $"<span class=\"position-absolute top-25 start-100 translate-middle badge rounded-pill bg-{badgeStatus}\">{badgeValue}</span>";
            htmlCode += "</button>";
            return new HtmlString(htmlCode);
        }
    }
}
