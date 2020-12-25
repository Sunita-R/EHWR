using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DTO.Notes
{
    public class AddNotesDTO
    {
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public string CreatedBy { get; set; }

    }
}
