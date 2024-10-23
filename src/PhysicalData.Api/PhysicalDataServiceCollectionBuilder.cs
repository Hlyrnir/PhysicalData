using PhysicalData.Infrastructure;

namespace PhysicalData.Api
{
    public class PhysicalDataServiceCollectionBuilder
    {
        public readonly IServiceCollection cltService;
        public virtual IServiceCollection Services { get=>cltService; }

        public PhysicalDataServiceCollectionBuilder(IServiceCollection cltService)
        {
            this.cltService = cltService;
        }

        public PhysicalDataServiceCollectionBuilder AddSqliteDatabase(string sConnectionStringName)
        {
            cltService.AddSqliteDatabase(sConnectionStringName);

            return new PhysicalDataServiceCollectionBuilder(Services);
        }
    }
}
