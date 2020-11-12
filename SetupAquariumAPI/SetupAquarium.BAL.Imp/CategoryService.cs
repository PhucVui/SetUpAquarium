using SetupAquarium.BAL.Interface;
using SetupAquarium.DAL.Interface;
using SetupAquarium.Domain.Reponse.Category;
using SetupAquarium.Domain.Request.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SetupAquarium.BAL.Imp
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<SaveCategoryRes> ChangeCategoryStatus(int id, int status)
        {
            return await categoryRepository.ChangeCategoryStatus(id,status);
        }

        public Task<CategoryView> Get(int id)
        {
            return categoryRepository.Get(id);
        }

        public Task<IEnumerable<CategoryView>> Gets()
        {
            return categoryRepository.Gets();
        }

        public Task<SaveCategoryRes> Save(SaveCategoryReq request)
        {
            return categoryRepository.Save(request);
        }
    }
}
