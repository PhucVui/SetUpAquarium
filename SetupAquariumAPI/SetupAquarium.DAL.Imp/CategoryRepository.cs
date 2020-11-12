using Dapper;
using SetupAquarium.DAL.Interface;
using SetupAquarium.Domain.Reponse.Category;
using SetupAquarium.Domain.Request.Category;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace SetupAquarium.DAL.Imp
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public async Task<SaveCategoryRes> ChangeCategoryStatus(int id, int status)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CategoryId", id);
            parameters.Add("@Status", status);
            return await SqlMapper.QueryFirstOrDefaultAsync<SaveCategoryRes>(cnn: connection,
                                                        sql: "sp_ChangeCategoryStatus",
                                                        param: parameters,
                                                        commandType: CommandType.StoredProcedure);
        }

        public async Task<CategoryView> Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            return await SqlMapper.QueryFirstAsync<CategoryView>(cnn: connection,
                                                        sql: "sp_GetCategoryById",
                                                        param: parameters,
                                                        commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<CategoryView>> Gets()
        {
            return await SqlMapper.QueryAsync<CategoryView>(cnn: connection,
                                                        sql: "sp_GetCategories",
                                                        commandType: CommandType.StoredProcedure);
        }

        public async Task<SaveCategoryRes> Save(SaveCategoryReq request)
        {
            var result = new SaveCategoryRes()
            {
                CategoryId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryId", request.CategoryId);
                parameters.Add("@CategoryName", request.CategoryName);
                parameters.Add("@Status", request.Status);

                result = await SqlMapper.QueryFirstOrDefaultAsync<SaveCategoryRes>(cnn: connection,
                                                                    sql: "sp_SaveCategory",
                                                                    param: parameters,
                                                                    commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }
    }
}
