namespace SleeDigital.LabelStore.Library.Models
{
    public class User
    {
        public User()
        {
            id = Guid.NewGuid().ToString();
            Roles = new List<string>();
        }
        public string id { get; set; }
        public string? AzureObjectId { get; set; }
        public string? EmailAddress { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<string> Roles { get; set; }
    }
}