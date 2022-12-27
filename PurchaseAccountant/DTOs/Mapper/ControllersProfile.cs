using AutoMapper;
using PurchaseAccountant.Entities;

namespace PurchaseAccountant.DTOs.Mapper
{
    public class ControllersProfile : Profile
    {
        public ControllersProfile()
        {
            CreateMap<CategoryAddModel, Category>();
            CreateMap<RecordAddModel, Record>();

            CreateMap<Record, RecordResponse>();
            CreateMap<Category, CategoryResponse>();
        }
    }
}
