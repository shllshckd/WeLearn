﻿using System.Collections.Generic;

using WeLearn.Web.ViewModels.Category;

namespace WeLearn.Services.Data.Interfaces
{
    public interface ICategoriesService
    {
        int GetCount();

        IEnumerable<CategoryViewModel> GetAllCategories();
    }
}