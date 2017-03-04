using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace IBAWeb2
{
    /// <summary>
    /// Summary description for LoginHandler1
    /// </summary>
    public class LoginHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            bool IsValid = true;


            //See Option for 
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            context.Response.Write(IsValid);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}