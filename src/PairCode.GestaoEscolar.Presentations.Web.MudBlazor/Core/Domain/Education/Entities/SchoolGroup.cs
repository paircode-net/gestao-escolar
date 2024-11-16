namespace PairCode.GestaoEscolar.Presentations.Web.MudBlazor.Core.Domain.Education.Entities
{
    public class SchoolGroup
    {
        public long Id { get; set; }
        public string TradeName { get; set; }
        public string CompanyName { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public DateTime FoundedAt { get; set; }
        public virtual ICollection<School> Schools { get; set; }
        public SchoolGroup()
        {
            
        }
    }
}
