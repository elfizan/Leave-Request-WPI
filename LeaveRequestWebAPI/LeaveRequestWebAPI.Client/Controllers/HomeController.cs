﻿using LeaveRequestWebAPI.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LeaveRequestWebAPI.Client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult Login(string returnURL)
        //{
        //    var userinfo = new LoginVM();

        //    try
        //    {
        //        // We do not want to use any existing identity information
        //        EnsureLoggedOut();

        //        // Store the originating URL so we can attach it to a form field
        //        userinfo.ReturnURL = returnURL;

        //        return View(userinfo);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
        ////GET: EnsureLoggedOut
        //private void EnsureLoggedOut()
        //{
        //    // If the request is (still) marked as authenticated we send the user to the logout action
        //    if (Request.IsAuthenticated)
        //        Logout();
        //}

        ////POST: Logout
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Logout()
        //{
        //    try
        //    {
        //        // First we clean the authentication ticket like always
        //        //required NameSpace: using System.Web.Security;
        //        FormsAuthentication.SignOut();

        //        // Second we clear the principal to ensure the user does not retain any authentication
        //        //required NameSpace: using System.Security.Principal;
        //        HttpContext.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);

        //        Session.Clear();
        //        System.Web.HttpContext.Current.Session.RemoveAll();

        //        // Last we redirect to a controller/action that requires authentication to ensure a redirect takes place
        //        // this clears the Request.IsAuthenticated flag since this triggers a new request
        //        return RedirectToLocal();
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        ////GET: SignInAsync
        //private void SignInRemember(string userName, bool isPersistent = false)
        //{
        //    // Clear any lingering authencation data
        //    FormsAuthentication.SignOut();

        //    // Write the authentication cookie
        //    FormsAuthentication.SetAuthCookie(userName, isPersistent);
        //}

        ////GET: RedirectToLocal
        //private ActionResult RedirectToLocal(string returnURL = "")
        //{
        //    try
        //    {
        //        // If the return url starts with a slash "/" we assume it belongs to our site
        //        // so we will redirect to this "action"
        //        if (!string.IsNullOrWhiteSpace(returnURL) && Url.IsLocalUrl(returnURL))
        //            return Redirect(returnURL);

        //        // If we cannot verify if the url is local to our host we redirect to a default location
        //        return RedirectToAction("Index", "Dashboard");
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}


    }
}