using QLHSC07.Entity.CRM;
using QLHSC07.Model.CRM.ClientNote;
using QLHSC07.Services.BaseServices;

namespace QLHSC07.Services.Interfaces.CRM
{
    public interface IClientNoteService : IBaseService<long, ClientNote, ClientNoteViewDto, ClientNoteViewDto, CreateClientNoteDto, UpdateClientNoteDto, FilterClientNoteDto>
    {
    }
}
