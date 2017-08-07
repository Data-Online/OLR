using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

// Duplicate from OLRapi application. Use this as the copy.

namespace OLR.UI.Helpers
{
    public static class Settings
    {
        public static string GraphApiKey => ConfigurationManager.AppSettings["SendGridApi"];

        public static string RegistrationUrl => ConfigurationManager.AppSettings["RegistrationUrl"];
        public static string RegistrationUrlApi => ConfigurationManager.AppSettings["RegistrationUrlApi"];

        public static string EventUID => ConfigurationManager.AppSettings["EventUID"];

        public static bool AllowDuplicateeMail = ConfigurationManager.AppSettings["AllowDuplicateeMail"] == "true" ? true : false;
        public static bool UseApi = ConfigurationManager.AppSettings["UseApi"] == "true" ? true : false;
    }
}