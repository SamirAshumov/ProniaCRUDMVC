﻿using Microsoft.AspNetCore.Mvc;
using Pronia.Business.Services.Abstracts;
using Pronia.Core.Models;

namespace ProniaCRADTask.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;
        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        public IActionResult Index()
        {
            var features = _featureService.GetAllFeatures();
            return View(features);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Feature feature)
        {
            if (!ModelState.IsValid)
                return View();

            _featureService.AddFeature(feature);
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult DeletePost(int id)
        {
            _featureService.DeleteFeature(id);

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            var existFeature = _featureService.GetFeature(x => x.Id == id);

            if (existFeature == null)
            {
                return NotFound();
            }

            return View(existFeature);
        }




        public IActionResult Update(int id)
        {
            var existFeature = _featureService.GetFeature(x => x.Id == id);

            if (existFeature == null) throw new NullReferenceException();

            return View(existFeature);
        }

        [HttpPost]
        public IActionResult Update(Feature newFeature)
        {
            _featureService.UpdateFeature(newFeature.Id, newFeature);
            return RedirectToAction("index");
        }
    }
}
