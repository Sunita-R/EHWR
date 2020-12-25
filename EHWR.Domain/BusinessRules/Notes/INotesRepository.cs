using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Notes;
using EHWR.Domain.DTO.Notes;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Domain.BusinessRules.Notes
{
     public interface INotesRepository
    {
        Task<IEnumerable<NoteModel>> CollectionAsync(NotesSearch NotesSearch);
        Task<SpResponse> DeleteNote(Delete delete);
        Task<SpResponse> AddNotes(AddNotesDTO addNotesDTO);
    }
}
