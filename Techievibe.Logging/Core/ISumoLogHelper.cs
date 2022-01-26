using System;
using System.Collections.Generic;
using System.Text;

namespace Techievibe.Logging.Core
{
    public interface ISumoLogHelper
    {
        string GetFormattedErrorMessage(string errorMessage);
        string GetFormattedWarningMessage(string warningMessage);
        string GetFormattedInformationMessage(string informationMessage);
        string GetFormattedDebugMessage(string debugMessage);
    }
}
