using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SchoolManagment.Models.ViewModels;

namespace SchoolManagment.Helpers
{
  [HtmlTargetElement("div", Attributes = "page-model")]
  public class PageLinkTagHelper : TagHelper
  {
    private IUrlHelperFactory urlHelperFactory;

    public PageLinkTagHelper(IUrlHelperFactory helperFactory)
    {
      urlHelperFactory = helperFactory;
    }

    [ViewContext]
    [HtmlAttributeNotBound]
    public ViewContext ViewContext { get; set; }
    public PagingInfo PageModel { get; set; }
    public string PageAction { get; set; }

    [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
    public Dictionary<string, object> PageUrlValues { get; set;}
      = new Dictionary<string, object>();
    
    public bool PageClassesEnabled { get; set; }
    public string PageClass { get; set; }
    public string PageClassNormal { get; set; }
    public string PageClassSelected { get; set; }

    public override void Process(TagHelperContext context,
      TagHelperOutput output)
    {
      IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext); 
      TagBuilder result = new TagBuilder("div");

      int currentPage = PageModel.CurrentPage;
      int limit = PageModel.TotalPages > 5
        ? 5 : PageModel.TotalPages;
      int start = 1;

      if(currentPage >= 3) {
        limit = (currentPage + 2) > PageModel.TotalPages 
          ? PageModel.TotalPages : currentPage + 2;
        start = PageModel.TotalPages <= 5
          ? 1 : limit - 4;
      }

      for(int i = start; i <= limit; i++)
      {
        TagBuilder tag = new TagBuilder("a");
        PageUrlValues["page"] = i;
        tag.Attributes["href"] = urlHelper.Action(PageAction, PageUrlValues);

        if(PageClassesEnabled)
        {
          tag.AddCssClass(PageClass);
          tag.AddCssClass(i == PageModel.CurrentPage
            ? PageClassSelected : PageClassNormal);
        }
          
        tag.InnerHtml.Append(i.ToString());
        result.InnerHtml.AppendHtml(tag);
      }

      output.Content.AppendHtml(result.InnerHtml);
    }
    
  }
}