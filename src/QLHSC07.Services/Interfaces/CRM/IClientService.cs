using QLHSC07.Entity.CRM;
using QLHSC07.Model.CRM.Client;
using QLHSC07.Services.BaseServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Services.Interfaces.CRM
{
    public interface IClientService : IBaseService<long, Client, ClientViewDto, ClientViewDto, CreateClientDto, UpdateClientDto, FilterClientDto>
    {
        IList<ClientLookupDto> GetLookup();
    }
}
