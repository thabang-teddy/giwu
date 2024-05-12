using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class BibleRootObject
    {
        public Resultset resultset { get; set; }
    }

    public class Resultset
    {
        public List<Row> row { get; set; }
    }

    public class Row
    {
        public List<object> field { get; set; }
    }

    public class BibleVersionRootObject
    {
        public ResultVersionset resultset { get; set; }
    }

    public class ResultVersionset
    {
        public object keys { get; set; }
    }
}
