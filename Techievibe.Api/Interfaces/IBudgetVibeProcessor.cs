using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techievibe.Models.Api;

namespace Techievibe.Api.Interfaces
{
    interface IBudgetVibeProcessor
    {
        void ProcessTransaction(Transaction transaction);
    }
}
