﻿using Microsoft.AspNetCore.Mvc;
using WAG.Services.Interfaces;
using WAG.ViewModels.ArtisticWorks;

namespace WAG.WebApp.Areas.BG.Controllers
{
    public class ArtisticWorkController : BGController
    {
        private IArtisticWorkService ArtisticWorkService;

        public ArtisticWorkController(IArtisticWorkService artisticWorkService)
        {
            this.ArtisticWorkService = artisticWorkService;
        }

        public IActionResult Categories(ArtWorkCategoriesViewModel categoriesViewModel)
        {
            categoriesViewModel.Categories = ArtisticWorkService.GetArtisticWorkCategories();

            return View(categoriesViewModel);
        }

        public IActionResult ArtWorksByCategory(int id)
        {
            var artWorkViewModel = new ArtWorkCollectionViewModel()
            {
                ArtWorkCollection = ArtisticWorkService.GetArtWorksByCategoryId(id),
                ArtWorkCategory = ArtisticWorkService.GetCategoryById(id),
            };

            if (artWorkViewModel.ArtWorkCollection == null || artWorkViewModel.ArtWorkCategory == null)
            {
                return RedirectToAction("Categories", "ArtisticWork");
            }

            return View(artWorkViewModel);
        }

        public IActionResult ArtWorkDetails(int id)
        {
            var viewModel = new ArtWorkDetailsViewModel()
            {
                ArtisticWork = ArtisticWorkService.GetArtisticWorkById(id)
            };

            if (viewModel.ArtisticWork == null)
            {
                return RedirectToAction("Categories", "ArtisticWork");
            }

            viewModel.ArtisticWork.ArtisticWorkCategory = ArtisticWorkService.GetCategoryById(viewModel.ArtisticWork.ArtisticWorkCategoryId);

            return View(viewModel);
        }
    }
}