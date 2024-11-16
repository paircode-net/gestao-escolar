namespace PairCode.GestaoEscolar.Presentations.Web.MudBlazor.Core.Domain.Education.Entities
{
    public class School
    {
        public long Id { get; set; }
        public string TradeName { get; set; }
        public string CompanyName { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public DateTime FoundedAt { get; set; }

        public long? SchoolGroupId { get; set; }
        public virtual SchoolGroup SchoolGroup { get; set; }
        public School()
        {
            
        }
    }
}
