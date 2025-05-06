using CarService.DataAccess.Abstract;
using CarService.Entities;
using CarService.Entities.Dto_s;
using Microsoft.AspNetCore.Mvc;

namespace CarService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataGetController : ControllerBase
    {

        private readonly IAppRepository _appRepository;

        public DataGetController(IAppRepository appRepository)
        {
            _appRepository = appRepository;
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

        [HttpPost("AddDetail")]
        public void AddDetail([FromBody] AddDetailDto detailDto, int count, int categoryId )
        {
            detailDto.Count = count;
            detailDto.CategoryId = categoryId;
            _appRepository.AddAsync(detailDto);
        }

        [HttpDelete("DetailDelete")]
        public async void DeleteDetail(int id)
        {
            var detail = await _appRepository.GetDetail(id);

            await _appRepository.DeleteAsync(detail);
        }

        [HttpPost("AddCategory")]
        public async void AddCategory([FromBody] AddCategoryDto addCategory)
        {
            await _appRepository.AddAsync(addCategory);
        }

        [HttpDelete("CategoryDelete/{id}")]
        public async void CategoryDelite(int id)
        {
            var category = await _appRepository.GetCategory(id);

            await _appRepository.DeleteAsync(category);

        }
    }
}
