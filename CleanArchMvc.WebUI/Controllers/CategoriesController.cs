using CleanArchMvc.Application.DTOS;
using CleanArchMvc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchMvc.WebUI.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService) 
        {
            _categoryService = categoryService; 
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories =await _categoryService.GetCategories();
            return View(categories);
        }




        [HttpPost]
        public async Task<IActionResult> Create(CategoryDTO cat)
        {   if (ModelState.IsValid)
            {

                try
                {

                    await _categoryService.Add(cat);
                    return View("Index"); 

                }
                catch (System.Exception)
                {

                    throw;
                }



            }


            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {


            return View();
        }



        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var categoryDto = await _categoryService.GetCategoryById(id);
            if (categoryDto == null)
            {
                return NotFound();
            }

            return View(categoryDto);

        }


        [HttpPost,ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    await _categoryService.Delete(id);
                }
                catch (System.Exception)
                {

                    throw;
                }

                return View(id);
            }


            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var categoryDto = await _categoryService.GetCategoryById(id);
            if (categoryDto == null)
            {
                return NotFound();
            }

            return View(categoryDto);

        }

        [HttpPost]

        public async Task<IActionResult >Edit(CategoryDTO categoryDTO)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    await _categoryService.Update(categoryDTO);
                }
                catch (System.Exception)
                {

                    throw;
                }

                return View(categoryDTO);
            }


            return View();
        }



        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var categoryDto = await _categoryService.GetCategoryById(id);
            if (categoryDto == null)
            {
                return NotFound();
            }

            return View(categoryDto);

        }



    }
}
