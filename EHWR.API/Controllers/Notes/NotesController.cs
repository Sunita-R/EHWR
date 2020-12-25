using EHWR.Domain.DomainModel;
using EHWR.Domain.DomainModel.Notes;
using EHWR.Domain.DTO.Notes;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces.Notes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHWR.API.Controllers.Notes
{
    [ApiController]
    [Route("api/[controller]")]

    public class NotesController: ControllerBase
    {
        private readonly INotesService _noteService;
        public NotesController(INotesService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] NotesSearch NotesSearch)
        {
            IEnumerable<NoteModel> collection = await _noteService.CollectionAsync(NotesSearch);
            return Ok(collection);
        }

        [HttpDelete]

        public async Task<IActionResult> Delete([FromQuery] Delete delete)
        {
            SpResponse JobDeleted = await _noteService.DeleteNote(delete);
            return Ok(JobDeleted);
        }

        [HttpPost]
        // [ProducesResponseType((SpResponse)HttpStatusCode.OK)]
        // [ProducesResponseType((SpResponse)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> POST(AddNotesDTO model)
        {
            //JobModel JobScreen = new DTOMapper<JobOrderDTO, AddJobModel>().Serialize(model);
            SpResponse NotesAdded = await _noteService.AddNotes(model);
            return Ok(NotesAdded);
        }
    }
}
