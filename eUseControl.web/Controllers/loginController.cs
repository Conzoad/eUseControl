using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
//using eUseControl.businesslogic.Interfaces;
//using eUseControl.Domain.Entityes.Auth;
//using eUseControl.Domain.Entityes.GeneralResponce;
//using eUseControl.Domain.Entityes.User;
using eUseControl.web.Models;
using eUseControl.Web.Models;

namespace eUseControl.Web.Controllers
{
    //public class LoginController : Controller
    //{

    //    internal ISession _session;
    //    public LoginController()
    //    {
    //        var logicBl = new businesslogic.businesslogic();
    //        _session = logicBl.GetSessionBL();
    //    }

    //    // GET: Login
    //    public ActionResult Index()
    //    {
    //        return View();
    //    }

    //    [HttpPost]
    //    public ActionResult Index(LoginData data)
    //    {

    //        var uLoginData = new ULoginData
    //        {
    //            Credential = data.Username,
    //            Password = data.Password,
    //            Ip = "",
    //            FirstLoginTime = DateTime.Now
    //        };

    //        RResponceData responce = _session.UserLoginAction(uLoginData);
    //        if (responce != null && responce.Status)
    //        {
    //            //here will be the logic to Coockie Generation
    //            UCoockieData cData = _session.GenCoockieAlgo(responce.CurrentUser);

    //            if (cData != null)
    //            {
    //                //SET COOCKKE TO USER BROWSER
    //            }
    //        }


    //        return View();
    //    }
    //}
}