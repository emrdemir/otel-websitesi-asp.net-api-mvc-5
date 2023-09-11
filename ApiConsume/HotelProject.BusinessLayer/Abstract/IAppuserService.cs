using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IAppuserService : IGenericService<AppUser>
    {
        List<AppUser> TUserListWithWorkLocation();
    }
}
