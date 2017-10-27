using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Entities
{
    [Table("tbl_queue")]
    public class Queue
    {
        [Key]
        public int queue_id { get; set; }
        public int transaction_id { get; set; }
        public int activity_type_id { get; set; }

        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
    }
}