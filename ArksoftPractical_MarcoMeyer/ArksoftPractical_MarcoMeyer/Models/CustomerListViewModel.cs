namespace ArksoftPractical_MarcoMeyer.Models
{
    public class CustomerListViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
        public string FilterName { get; set; }
        public string FilterVat { get; set; }
        public string SortField { get; set; }
        public bool SortAsc { get; set; }
        public int Page { get; set; }
        public int TotalPages { get; set; }
    }
}