namespace Continent.Server.Business
{
    public class BusinessBase<TBusiness> where TBusiness : class
    {
        public TBusiness Data { get; set; }
    }
}
