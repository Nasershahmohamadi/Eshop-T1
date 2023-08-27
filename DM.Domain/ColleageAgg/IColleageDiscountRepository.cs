using Framework.Domain;

namespace DM.Domain.ColleageAgg
{
    public interface IColleageDiscountRepository :IRepository<long , ColleageDiscount>
    {
        bool Edit(ColleageDiscount command);
        bool Delete(long id);
        bool Active(long id);
        bool DisActive(long id);
        void SaveChanges();
    }
}
