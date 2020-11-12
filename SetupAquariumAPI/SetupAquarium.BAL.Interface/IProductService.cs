using SetupAquarium.Domain.Reponse.Product;
using SetupAquarium.Domain.Request.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SetupAquarium.BAL.Interface
{
    public interface IProductService
    {
        Task<IEnumerable<ProductView>> Gets();
        Task<ProductView> Get(int id);
        Task<SaveProductRes> Save(SaveProductReq request);
        Task<SaveProductRes> ChangeProductStatus(int id, int status);
    }
}
