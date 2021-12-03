﻿using System.Collections.Generic;
using System.Linq;

using AutoMapper;
using WeLearn.Data;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models;
using WeLearn.Data.Repositories;
using WeLearn.Services.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Category;

namespace WeLearn.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoryRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoryRepository)
            => this.categoryRepository = categoryRepository;

        public IEnumerable<CategoryViewModel> GetAllCategories()
            => this.categoryRepository.All().To<CategoryViewModel>().ToArray();

        public int GetAllCategoriesCount()
            => this.categoryRepository.All().Count();
    }
}
