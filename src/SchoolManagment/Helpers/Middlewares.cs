namespace SchoolManagment.Helpers
{
  public class UrlSessionMiddleware
  {
    private readonly RequestDelegate next;

    public UrlSessionMiddleware(RequestDelegate nextDelegate)
    {
      next = nextDelegate;
    }

    public async Task Invoke(HttpContext context)
    {
      context.Session.SetString("url", context.Request.Headers["Referer"]);

      await next(context);
    }
  }
}