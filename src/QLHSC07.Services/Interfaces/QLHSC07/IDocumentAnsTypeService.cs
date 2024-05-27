using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.DocumentAnsType;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;

namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IDocumentAnsTypeService : IBaseService<long, DocumentAnsType, DocumentAnsTypeDto, DocumentAnsTypeDto, CreateDocumentAnsTypeDto, UpdateDocumentAnsTypeDto, FilterDocumentAnsTypeDto>
    {
        IList<DocumentAnsTypeLookupDto> GetLookupDocumentAnsType();
    }
}
