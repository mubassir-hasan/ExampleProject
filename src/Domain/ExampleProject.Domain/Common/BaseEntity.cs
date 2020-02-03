using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleProject.Domain.Common
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
