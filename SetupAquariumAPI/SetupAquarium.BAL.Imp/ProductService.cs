using SetupAquarium.BAL.Interface;
using SetupAquarium.DAL.Interface;
using SetupAquarium.Domain.Reponse.Product;
using SetupAquarium.Domain.Request.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SetupAquarium.BAL.Imp
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<SaveProductRes> ChangeProductStatus(int id, int status)
        {
            return await productRepository.ChangeProductStatus(id,status);
        }

        public async Task<ProductView> Get(int id)
        {
            return await productRepository.Get(id); ;
        }

        public async Task<IEnumerable<ProductView>> Gets()
        {
            return await productRepository.Gets();
        }

        public async Task<SaveProductRes> Save(SaveProductReq request)
        {
            return await productRepository.Save(request);
        }
    }
}
