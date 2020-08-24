using CommonLibrary.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxitripApi.Handlers
{
    public class DatabaseHandler
    {
        public static string ExecuteQuery(string queryFileName)
        {
            string queryString = EmbeddedJsonResourceHandler.Read(queryFileName);
        }
    }
}
