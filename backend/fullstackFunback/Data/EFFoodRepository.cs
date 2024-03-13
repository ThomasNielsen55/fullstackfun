namespace fullstackFunback.Data
{
    public class EFFoodRepository : IFoodRepository
    {
        private MFoodContext _foodContext;
        public EFFoodRepository(MFoodContext temp) { 
            _foodContext = temp;
        }
        public IEnumerable<MarriottFood> Foods => _foodContext.Foods;
    }
}
