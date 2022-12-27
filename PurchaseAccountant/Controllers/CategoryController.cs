using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PurchaseAccountant.Data.Repositories.Categories;
using PurchaseAccountant.DTOs;
using PurchaseAccountant.Entities;
using PurchaseAccountant.Infrastructure.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PurchaseAccountant.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/category")]
    public class CategoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public readonly IHttpContextAccessor _httpContextAccessor;
        public CategoryController(
            ICategoryRepository categoryRepository,
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost]
        public async Task<ActionResult> AddCategory([FromBody] CategoryAddModel model)
        {
            var category = _mapper.Map<Category>(model);
            category.UserId = _httpContextAccessor.HttpContext.User.GetUserId();

            var categoryId = await _categoryRepository.AddCategoryAsync(category);
            return Ok($"Success. CategoryId = {categoryId}");
        }

        [HttpGet("items")]
        public async Task<IEnumerable<CategoryResponse>> GetAllCategories()
        {
            var userId = _httpContextAccessor.HttpContext.User.GetUserId();
            var categories = await _categoryRepository.GetAllCategories(userId);

            return _mapper.Map<IEnumerable<CategoryResponse>>(categories);
        }
    }
}
