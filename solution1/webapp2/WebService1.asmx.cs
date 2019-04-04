﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webapp2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Add(int a,int b)
        {
            return a+b;
        }

        [WebMethod]
        public int Subtract(int a,int b)
        {
            return a-b;
        }

        [WebMethod]
        public int Multiply(int a,int b)
        {
            return a*b;
        }

        [WebMethod]
        public int Divide(int a, int b)
        {
            return a/b;
        }

        
    }
}
