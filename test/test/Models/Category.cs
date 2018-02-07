using System;
using System.Collections.Generic;

namespace test.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModfiBy { get; set; }
        public int? Status { get; set; }
        public string Code { get; set; }
    }
}
