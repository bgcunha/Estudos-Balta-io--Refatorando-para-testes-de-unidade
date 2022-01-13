
using System.Linq.Expressions;
using Store.Domain.Entities;

namespace Store.Domain.Queries;

public static class ProductQueries
{
    public static Expression<Func<Product, bool>> GetActivePrducts()
    {
        return x => x.Active;
    }

    public static Expression<Func<Product, bool>> GetInactivePrducts()
    {
        return x => x.Active == false;
    }
}