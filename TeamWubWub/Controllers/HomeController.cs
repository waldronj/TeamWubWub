using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TweetSharp;

namespace TeamWubWub.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            Tweet();

            return View();
        }


        public ActionResult Tweet()
        {
            var _consumerKey = "Z9L41GpZxoPALVZr5WHUFA";
            var _consumerSecret = "kRPuscAQCBoHxq79djBQt7AYShqWCkCdORsYjro";
            var _accessTokenSecret = "KbYT8DnLtliUTW2RTveokuleSxkMt8BMtsNHwXMk";
            var _accessToken = "1382790648-pQE6otoIvvMjwFA15pLJbUHTxo2aW7pa1wGxnr1";

            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);
            service.SendTweet(new SendTweetOptions {Status = "TeamWubWub testing out the Twitter API!"});
            return null;
        }
        
    }
}
