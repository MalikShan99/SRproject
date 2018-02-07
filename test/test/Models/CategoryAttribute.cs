using System;
using System.Collections.Generic;

namespace test.Models
{
    public partial class CategoryAttribute
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public int Status { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int? IdCategory { get; set; }
    }
}
