using EMRS.Domain;
using EMRS.Model;
using System.Collections.Generic;

namespace EMRS.Mapper
{
    /// <summary>
    /// 数据库表-实体映射静态扩展类
    /// </summary>
    public static class MappingExtensions
    {
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            return AutoMapperConfiguration.Mapper.Map<TSource, TDestination>(source);
        }

        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            return AutoMapperConfiguration.Mapper.Map(source, destination);
        }



        #region DrugApplication
        public static CreateDrugListViewModel ToModel(this DRUG_PROVIDE_APPLICATION entity)
        {
            return entity.MapTo<DRUG_PROVIDE_APPLICATION, CreateDrugListViewModel>();
        }

        public static DRUG_PROVIDE_APPLICATION ToEntity(this CreateDrugListViewModel model)
        {
            return model.MapTo<CreateDrugListViewModel, DRUG_PROVIDE_APPLICATION>();
        }


        public static List<CreateDrugListViewModel> ToModelList(this List<DRUG_PROVIDE_APPLICATION> entityList)
        {
            return entityList.MapTo<List<DRUG_PROVIDE_APPLICATION>, List<CreateDrugListViewModel>>();
        }

        public static List<DRUG_PROVIDE_APPLICATION> ToEntityList(this List<CreateDrugListViewModel> modelList)
        {
            return modelList.MapTo<List<CreateDrugListViewModel>, List<DRUG_PROVIDE_APPLICATION>>();
        }
        #endregion

    }
}
