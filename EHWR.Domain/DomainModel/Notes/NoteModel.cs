using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.DomainModel.Notes
{
    public class NoteModel
    {
        public int NoteId { get; set; }
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public string  Notes { get; set; }
        public string CreatedBy { get; set; }
    }
    public class NotesSearch
    {
        public int InvoiceId { get; set; }
        public int NoteId { get; set; }

    }

}
