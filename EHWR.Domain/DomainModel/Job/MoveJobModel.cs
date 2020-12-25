using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.Job
{
    public class MoveJobModel
    {
        public int CustomerId { get; set; }

    }

    public class SearchMoveJob
    {
        public int assignjobtocustomer { get; set; }
        public int assignjobfromcustomer { get; set; }
        public int joborderid { get; set; }
        public string modifiedby { get; set; }

    }
}
