using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TaghelpController.TagHelpers
{
    [HtmlTargetElement("a1")]
    public class TaghelpController : TagHelper
    {
        public string source { get; set; }
        public string text { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";
            output.TagMode = TagMode.StartTagOnly;

            output.Attributes.SetAttribute("src", source);
            output.Attributes.SetAttribute("atl", text);
        }
    }
}
   
