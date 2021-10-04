using EasyASPSiteExample_1.Domain.Entities;
using System;
using System.Linq;

namespace EasyASPSiteExample_1.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }

}
