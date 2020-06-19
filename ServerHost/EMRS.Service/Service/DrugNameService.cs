using EMRS.Domain;
using EMRS_Repository;

namespace EMRS.Services
{
    public class DrugNameService : GenericService<DRUG_NAME_DICT>, IDrugNameService
    {
        private readonly IDrugNameRepository _repository = new DrugNameRepository();

        public string GetDrugName(string code)
        {
            return _repository.GetDrugName(code);
        }
    }
}
