using GetGitHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GetGitHub.Controllers
{
    public class WebScrapingController : ApiController
    {
        /// <summary>
        /// Returns the total number of lines and the total number of bytes of all files in the public Github repository, by file extension.
        /// </summary>
        /// <param name="user">Github user</param>
        /// <param name="repo">Github repository</param>
        /// <returns>Listing by file extension with the number of lines and total bytes.</returns>
        public List<WebScrapingResult> Get(string user, string repo)
        {
            return new Domain.WebScraping().GetGitHub(user, repo);
        }
    }
}
