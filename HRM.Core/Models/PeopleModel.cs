
using System;

namespace TestTask.Core.Models
{
    public class PeopleModel
    {
        public string FIO { get; set; }
        public DateTime? DateEmploy { get; set; }
        public DateTime? DateUneploy { get; set; }
        public string Status { get; set; }
        public string Dep { get; set; }
        public string Post { get; set; }
    }
}
