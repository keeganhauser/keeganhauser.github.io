using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace keeganhauser.github.io;

public class Page : PageModel
{
    [FromRoute]
    public string Slug { get; set; }
}