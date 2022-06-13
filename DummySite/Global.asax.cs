using DummySite.Resources;
using System;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Localization;
using DummySite.Utils;

namespace DummySite
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Bootstrapper.Bootstrapped += Bootstrapper_Bootstrapped;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
        private void Bootstrapper_Bootstrapped(object sender, EventArgs e)
        {
            // Register any Resource classes
            Res.RegisterResource<CustomRegistrationFormResource>();

        }
    }
}