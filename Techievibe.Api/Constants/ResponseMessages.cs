using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Techievibe.Api.Constants
{
    public static class ResponseMessages
    {
        public const string BadRequestMessage = "There is something wrong with your request.";
        public const string TransactionCreatedSuccessMessage = "Transaction {TransactionId} added successfully.";
        public const string NotFoundMessage = "The requested resource was not found in the system";
    }
}
