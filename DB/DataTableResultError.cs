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
     public class DataTableResultError<T> : DataTableResultSet<T>
    {
        public string error;
    }
}
