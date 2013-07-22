﻿using System.Linq;

using BetterCms.Core.DataAccess;
using BetterCms.Core.DataAccess.DataContext;

using ServiceStack.ServiceInterface;

namespace BetterCms.Module.Api.Operations.Root.Categories.Category
{
    public class CategoryService : Service, ICategoryService
    {
        private readonly IRepository repository;

        public CategoryService(IRepository repository)
        {
            this.repository = repository;
        }

        public GetCategoryResponse Get(GetCategoryRequest request)
        {
            // TODO: validate CategoryId or CategoryName - one must be required

            var query = repository.AsQueryable<Module.Root.Models.Category>();

            if (request.Data.CategoryId.HasValue)
            {
                query = query.Where(category => category.Id == request.Data.CategoryId);
            }
            else
            {
                query = query.Where(category => category.Name == request.Data.CategoryName);
            }

            var model = query
                .Select(category => new CategoryModel
                    {
                        Id = category.Id,
                        Version = category.Version,
                        CreatedBy = category.CreatedByUser,
                        CreatedOn = category.CreatedOn,
                        LastModifiedBy = category.ModifiedByUser,
                        LastModifiedOn = category.ModifiedOn,

                        Name = category.Name
                    })
                .FirstOne();

            return new GetCategoryResponse
                       {
                           Data = model
                       };
        }
    }
}