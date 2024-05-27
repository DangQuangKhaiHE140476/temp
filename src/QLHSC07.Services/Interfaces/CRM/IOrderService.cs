using QLHSC07.Entity.CRM;
using QLHSC07.Model.CRM.Order;
using QLHSC07.Services.BaseServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Services.Interfaces.CRM
{
    public interface IOrderService : IBaseService<long, Order, OrderViewDto, OrderViewDto, CreateOrderDto, UpdateOrderDto, FilterOrderDto>
    {
    }
}
