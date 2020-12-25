using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules.Notes;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Notes;
using EHWR.Domain.DTO.Notes;
using EHWR.Domain.Response;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Note
{
    public class NotesRepository : GenericRepository, INotesRepository
    {
        public NotesRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<SpResponse> AddNotes(AddNotesDTO addNotesDTO)
        {
            return await CommandAsync<SpResponse>("AddInvoiceNotes", addNotesDTO);
        }

        public async Task<IEnumerable<NoteModel>> CollectionAsync(NotesSearch NotesSearch)
        {
            return await CollectionsAsync<NoteModel>("GetInvoiceNotesList", NotesSearch);
        }

        public async Task<SpResponse> DeleteNote(Delete delete)
        {
            return await CommandAsync<SpResponse>("DeleteInvoiceNotes", delete);
        }
    }
}
