using CarService.DataAccess;
using CarService.DataAccess.Abstract;
using CarService.Entities;
using CarService.Entities.Dto_s;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;

namespace CarService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataGetController : ControllerBase
    {

        private readonly IAppRepository _appRepository;
        private readonly AppDataContext _appDataContext;

        public DataGetController(IAppRepository appRepository, AppDataContext appDataContext)
        {
            _appRepository = appRepository;
            _appDataContext = appDataContext;
        }

        [HttpGet("categorylist")]
        public Task<List<Category>> GetCategoryList()
        {

            var categories = _appRepository.GetAllCategory();

            return categories;
        }

        [HttpGet("category/{id}")]
        public Task<Category> GetCategory(int id)
        {
            var category = _appRepository.GetCategory(id);

            return category;
        }

        [HttpGet("detailList")]
        public Task<List<Detail>> GetDetailList()
        {

            var details = _appRepository.GetAllDetails();

            return details;
        }

        [HttpGet("detail/{id}")]
        public Task<Detail> GetDetail(int id)
        {
            var detail = _appRepository.GetDetail(id);

            return detail;
        }

        [HttpGet("detailByCategory/{id}")]
        public async Task<List<Detail>> DetailByCategory(int id)
        {
            var detail = await _appRepository.GetAllDetailsByCategory(id);

            return detail;
        }

        [HttpPost("adddetail")]
        public async Task AddDetail([FromBody] AddDetailDto detailDto)
        {
            var detail = new Detail
            {
                Name = detailDto.Name,
                Price = detailDto.Price,
                ImageUrl = detailDto.ImageUrl,
                Count = detailDto.Count,
                CategoryId = detailDto.CategoryId,
            };

            await _appRepository.AddAsync(detail);

            await _appDataContext.SaveChangesAsync();
        }

        [HttpDelete("DetailDelete/{id}")]
        public async Task DeleteDetail(int id)
        {
            var detail = await _appRepository.GetDetail(id);

            await _appRepository.DeleteAsync(detail);

            await _appRepository.SaveAllAsync();
        }

        [HttpPost("AddCategory")]
        public async Task AddCategory([FromBody] AddCategoryDto addCategory)
        {
            var category = new Category
            {
                Name = addCategory.Name,
            };

            await _appRepository.AddAsync(category);

            await _appDataContext.SaveChangesAsync();       
        }

        [HttpDelete("CategoryDelete/{id}")]
        public async Task CategoryDelite(int id)
        {
            var category = await _appRepository.GetCategory(id);

            await _appRepository.DeleteAsync(category);

            await _appRepository.SaveAllAsync();
        }
    }
}
