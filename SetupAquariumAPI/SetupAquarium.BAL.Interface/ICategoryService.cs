using SetupAquarium.Domain.Reponse.Category;
using SetupAquarium.Domain.Request.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SetupAquarium.BAL.Interface
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryView>> Gets();
        Task<CategoryView> Get(int id);
        Task<SaveCategoryRes> Save(SaveCategoryReq request);
        Task<SaveCategoryRes> ChangeCategoryStatus(int id, int status);
    }
}
