using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace Techievibe.Logging.Core
{
    public class SumoLogHelper : ISumoLogHelper
    {
        public string GetFormattedDebugMessage(string debugMessage)
        {
            string formattedMessage = "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
            formattedMessage += debugMessage;
            formattedMessage += "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";

            return formattedMessage;
        }

        public string GetFormattedErrorMessage(string errorMessage)
        {
            string formattedMessage = "********************************";
            formattedMessage += errorMessage;
            formattedMessage += "**********************************";

            return formattedMessage;
        }

        public string GetFormattedInformationMessage(string informationMessage)
        {
            string formattedMessage = "--------------------------------";
            formattedMessage += informationMessage;
            formattedMessage += "---------------------------------";

            return formattedMessage;
        }

        public string GetFormattedWarningMessage(string warningMessage)
        {
            string formattedMessage = "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@";
            formattedMessage += warningMessage;
            formattedMessage += "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@";

            return formattedMessage;
        }
    }
}
