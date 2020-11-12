using Dapper;
using SetupAquarium.DAL.Interface;
using SetupAquarium.Domain.Reponse.Product;
using SetupAquarium.Domain.Request.Product;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace SetupAquarium.DAL.Imp
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public async Task<SaveProductRes> ChangeProductStatus(int id, int status)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProductId", id);
            parameters.Add("@Status", status);
            return await SqlMapper.QueryFirstOrDefaultAsync<SaveProductRes>(cnn: connection,
                                                        sql: "sp_ChangeProductStatus",
                                                        param: parameters,
                                                        commandType: CommandType.StoredProcedure);
        }

        public async Task<ProductView> Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            return await SqlMapper.QueryFirstAsync<ProductView>(cnn: connection,
                                                        sql: "sp_GetProductById",
                                                        param: parameters,
                                                        commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ProductView>> Gets()
        {
            return await SqlMapper.QueryAsync<ProductView>(cnn: connection,
                                                        sql: "sp_GetProducts",
                                                        commandType: CommandType.StoredProcedure);
        }

        public async Task<SaveProductRes> Save(SaveProductReq request)
        {
            var result = new SaveProductRes()
            {
                ProductId = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ProductId", request.ProductId);
                parameters.Add("@ProductName", request.ProductName);
                parameters.Add("@Price", request.Price);
                parameters.Add("@AvatarPath", request.AvatarPath);
                parameters.Add("@CategoryId", request.CategoryId);
                parameters.Add("@AquariumSizeId", request.AquariumSizeId);
                parameters.Add("@Status", request.Status);

                result = await SqlMapper.QueryFirstOrDefaultAsync<SaveProductRes>(cnn: connection,
                                                                    sql: "sp_SaveProduct",
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
