﻿using Fina.Api.Data;
using Fina.Core.Handlers;
using Fina.Core.Models;
using Fina.Core.Requests.Categories;
using Fina.Core.Responses;

namespace Fina.Api.Handler
{
    public class CategoryHandler(AppDbContext context) : ICategoryHandler
    {
        public async Task<Response<Category?>> CreateAsync(CreateCategoryRequest request)
        {
            try
            {
                var category = new Category
                {
                    UserId = request.UserId,
                    Title = request.Title,
                    Description = request.Description,
                };

                await context.Categories.AddAsync(category);
                await context.SaveChangesAsync();

                return new Response<Category?>(category, 201, "Categoria adiciona com sucesso!");
            }
            catch(Exception ex) 
            {
                // Serilog, Opentelemetry
                return new Response<Category?>(null, 500, "Falha");
            }
        }

        public async Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResponse<List<Category>?>> GetAllAsync(GetAllCategoriesRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<Category?>> GetByIdAsync(GetCategoryByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
