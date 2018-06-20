using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatatablesDotNetServerSideHandler.DB
{
    //Thanks class from Olliejones for handle Datatable.net serverside
    //https://gist.github.com/OllieJones/7448933cc85ee740e990383e4fded412
    [Serializable]
    public class DataTableResultSet<T>
    {
        /// <summary>Array of records. Each element of the array is itself an array of columns</summary>
        public IEnumerable<T> data;

        /// <summary>value of draw parameter sent by client</summary>
        public int draw;

        /// <summary>filtered record count</summary>
        public int recordsFiltered;

        /// <summary>total record count in resultset</summary>
        public int recordsTotal;

        public string ToJSON()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

}
