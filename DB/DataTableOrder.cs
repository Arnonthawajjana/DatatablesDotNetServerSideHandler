using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatatablesDotNetServerSideHandler.DB
{
    //Thanks class from Olliejones for handle Datatable.net serverside
    //https://gist.github.com/OllieJones/7448933cc85ee740e990383e4fded412
    public class DataTableOrder
    {
        public int Column;
        public string Direction;

        private DataTableOrder()
        {
        }
        /// <summary>
        /// Retrieve the DataTables order dictionary from a JSON parameter list
        /// </summary>
        /// <param name="input">JToken object</param>
        /// <returns>Dictionary of Order elements</returns>
        public static Dictionary<int, DataTableOrder> Get(JToken input)
        {
            return (
                (JArray)input["order"])
                .Select(col => new DataTableOrder
                {
                    Column = (int)col["column"],
                    Direction =
                        ((string)col["dir"]).StartsWith("desc", StringComparison.OrdinalIgnoreCase) ? "DESC" : "ASC"
                })
                .ToDictionary(c => c.Column);
        }
    }
}
