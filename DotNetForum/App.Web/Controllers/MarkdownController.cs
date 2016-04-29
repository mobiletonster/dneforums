using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace App.Web.Controllers
{
    public class MarkdownController : ApiController
    {
        MarkdownSharp.Markdown _markdown;
        [HttpGet]
        public string Thing()
        {
            string text = @"# .Net Engineering Forum
## 2016 Apr 20
### MS Build 2016 Report

Attendees from Microsoft Build conference 2016 give their report.

### YouTube Channel
<iframe width='560' height='315' src='https://www.youtube.com/embed/eZJuUVqucsg' frameborder='0' allowfullscreen></iframe>

### You can jump to an individual speaker by clicking any of the links below.

Jim Byer -Keynotes -  [https://youtu.be/eZJuUVqucsg](https://youtu.be/eZJuUVqucsg)

Todd Pickering - VS2015 debugging - [https://youtu.be/eZJuUVqucsg?t=485](https://youtu.be/eZJuUVqucsg?t=485)

Alan Pehrson - VS Desktop Apps - [https://youtu.be/eZJuUVqucsg?t=1076](https://youtu.be/eZJuUVqucsg?t=1076)

Danny Staten - EF Core - [https://youtu.be/eZJuUVqucsg?t=1630](https://youtu.be/eZJuUVqucsg?t=1630)

Tom Maravilla - Bash on Windows - [https://youtu.be/eZJuUVqucsg?t=1978](https://youtu.be/eZJuUVqucsg?t=1978)

Gordon Young - ioT - [https://youtu.be/eZJuUVqucsg?t=2457](https://youtu.be/eZJuUVqucsg?t=2457)

Gordon Young - Asp.Net Core - [https://youtu.be/eZJuUVqucsg?t=2934](https://youtu.be/eZJuUVqucsg?t=2934)

Rich Haddock - Asp.Net Core - [https://youtu.be/eZJuUVqucsg?t=3274](https://youtu.be/eZJuUVqucsg?t=3274)

Rich Haddock - Bots - [https://youtu.be/eZJuUVqucsg?t=3549](https://youtu.be/eZJuUVqucsg?t=3549)

Matt Morey - Hackathon - [https://youtu.be/eZJuUVqucsg?t=3930](https://youtu.be/eZJuUVqucsg?t=3930)

Jon Worthington - MS Virtual Band Demo -  [https://youtu.be/eZJuUVqucsg?t=4174](https://youtu.be/eZJuUVqucsg?t=4174)


### View past Engineering Forums:

#### Nov 2015
It's never been a better time to be a .Net Engineer!
*[https://ip.app.lds.org/docs/net-engineering-forum-2015-nov](https://ip.app.lds.org/docs/net-engineering-forum-2015-nov)
*VIDEO: [https://www.youtube.com/watch?v=ZNLAywFwO0I](https://www.youtube.com/watch?v=ZNLAywFwO0I)

#### Dec 2015
GIT in Visual Studio 2015 / TFS and Build tools
*[https://ip.app.lds.org/docs/net-engineering-forum-2015-dec](https://ip.app.lds.org/docs/net-engineering-forum-2015-dec)
*VIDEO: [https://www.youtube.com/watch?v=vgqKxdTFpt8](https://www.youtube.com/watch?v=vgqKxdTFpt8)

#### Jan 2016
Microsoft Technologies!
Guest Speaker Dave McKinstry from Microsoft
*[https://ip.app.lds.org/docs/net-engineering-forum-2016-jan](https://ip.app.lds.org/docs/net-engineering-forum-2016-jan)
*VIDEO: [https://www.youtube.com/watch?v=ayvPpopoCMA](https://www.youtube.com/watch?v=ayvPpopoCMA)
    
#### Feb 2016
Entity Framework(6)
*[https://ip.app.lds.org/docs/net-engineering-forum-2016-feb](https://ip.app.lds.org/docs/net-engineering-forum-2016-feb)   
*VIDEO: [https://www.youtube.com/watch?v=9oJUeCYgrm0](https://www.youtube.com/watch?v=9oJUeCYgrm0)

#### Mar 2016
Asp.Net WebApi(2.2)
*[https://ip.app.lds.org/docs/net-engineering-forum-2016-mar](https://ip.app.lds.org/docs/net-engineering-forum-2016-mar)
*VIDEO: [https://www.youtube.com/watch?v=ghr3x_XqjvE](https://www.youtube.com/watch?v=ghr3x_XqjvE)


<div>
<h1> This is a header </h1>
<p> This section is a paragraph </p>
<ul>
<li> This is a bullet </li>
<ul>
</div>


            ";

            var fileText = System.IO.File.ReadAllText("C:\\Users\\mobil\\OneDrive\\Documents\\STACK\\NetEngineeringForum2016APR20.md");
            
                        _markdown = new MarkdownSharp.Markdown();
            var html =_markdown.Transform(fileText);
            return html;
        }
    }
}
