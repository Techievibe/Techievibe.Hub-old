using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techievibe.Models.Api;

namespace Techievibe.Api.Controllers.BudgetVibe
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        /// <summary>
        /// BudgetVibe - Adds a new transaction in the system.
        /// </summary>
        /// <remarks>
        /// POST /transaction/add
        /// This will add a new transaction in the system.
        /// </remarks>
        public static List<Transaction> transactions = new List<Transaction>();
        [HttpPost("add")]
        public ActionResult<string> AddTransaction([FromBody] Transaction transaction)
        {
            //var transaction = JsonConvert.DeserializeObject<Transaction>(transactionJson);

            if (transaction != null)
            {
                try
                {
                    transaction.TransactionId = Guid.NewGuid().ToString();

                    transactions.Add(transaction);

                    return StatusCode(StatusCodes.Status200OK, Constants.ResponseMessages.TransactionCreatedSuccessMessage.Replace("{transactionId}",transaction.TransactionId));
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex);
                }
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest, Constants.ResponseMessages.BadRequestMessage);
            }
        }

        [HttpGet("view/{transactionId}")]
        public ActionResult<Transaction> GetTransaction(string transactionId)
        {
            if (transactionId == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest, Constants.ResponseMessages.BadRequestMessage);
            }

            try
            {
                if (transactions.Count(x => x.TransactionId == transactionId) == 1)
                    return StatusCode(StatusCodes.Status200OK, transactions.First(x => x.TransactionId == transactionId));

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }

            return StatusCode(StatusCodes.Status404NotFound, Constants.ResponseMessages.NotFoundMessage);
        }

        [HttpGet("view/all")]
        public ActionResult<List<Transaction>> GetAllTransactions()
        {

            try
            {
                return StatusCode(StatusCodes.Status200OK, transactions);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
