namespace ASP_101.Models
{
    public class FeaturedViewModel
    {
        public int Id {  get; set; } required     
        public string Header { get; set; } required
        public string Title { get; set; } required
        public DateTime PostedDate { get; set; } 
        public string Description { get; set; } 
        public string ImageUrl { get; set; } 

    }
}
