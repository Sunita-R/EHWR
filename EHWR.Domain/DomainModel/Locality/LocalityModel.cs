using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.Locality
{
    public class LocalityModel
    {
        public int LocalityId { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public int PostCode { get; set; }
    }
    public class LocalitySearch
    {
        public string SearchValue { get; set; }
    }
}
