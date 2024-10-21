namespace PhysicalData.Api
{
    public class PhysicalDataServiceCollectionBuilder
    {

        public virtual IServiceCollection Services { get; }

        public PhysicalDataServiceCollectionBuilder(IServiceCollection clctService)
        {
            Services = clctService;
        }
    }
}
