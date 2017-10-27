using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Entities
{
    [Table("tbl_transactions")]
    public class Transactions
    {
        [Key]
        public int transaction_id { get; set; }
        public int project_id { get; set; }
        public int activity_type_id { get; set; }

        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }
}