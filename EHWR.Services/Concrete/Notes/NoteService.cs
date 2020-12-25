using EHWR.Domain.BusinessRules.Notes;
using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Notes;
using EHWR.Domain.DTO.Notes;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces.Notes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete.Notes
{
    public class NoteService : INotesService
    {
        private readonly INotesRepository _notesRepository;
        public NoteService(INotesRepository notesRepository)
        {
            _notesRepository = notesRepository;
        }

        public async Task<SpResponse> AddNotes(AddNotesDTO addNotesDTO)
        {
            return await _notesRepository.AddNotes(addNotesDTO);
        }

        public async Task<IEnumerable<NoteModel>> CollectionAsync(NotesSearch NotesSearch)
        {
            return await _notesRepository.CollectionAsync(NotesSearch);
        }

        public async Task<SpResponse> DeleteNote(Delete delete)
        {
            return await _notesRepository.DeleteNote(delete);
        }
    }
}
