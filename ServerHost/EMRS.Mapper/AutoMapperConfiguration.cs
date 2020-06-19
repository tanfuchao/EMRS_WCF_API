using AutoMapper;
using EMRS.Domain;
using EMRS.Model;

namespace EMRS.Mapper
{
    /// <summary>
    /// AutoMapper的全局实体映射配置静态类
    /// </summary>
    public static class AutoMapperConfiguration
    {
        public static void Init()
        {
            MapperConfiguration = new MapperConfiguration(cfg =>
            {

                //#region Post
                ////将领域实体映射到视图实体
                //cfg.CreateMap<Post, PostViewModel>()
                //    .ForMember(d => d.IsDeleted, d => d.MapFrom(s => s.IsDeleted ? "是" : "否")) //将布尔类型映射成字符串类型的是/否
                //;
                ////将视图实体映射到领域实体
                //cfg.CreateMap<PostViewModel, Post>();
                //#endregion

               

                #region DrugApplication
                cfg.CreateMap<DRUG_PROVIDE_APPLICATION, CreateDrugListViewModel>();
                cfg.CreateMap<CreateDrugListViewModel, DRUG_PROVIDE_APPLICATION>();

                #endregion
            });

            Mapper = MapperConfiguration.CreateMapper();
        }

        public static IMapper Mapper { get; private set; }

        public static MapperConfiguration MapperConfiguration { get; private set; }
    }
}
