using System;
namespace SleeDigital.LabelStore.Library.Models
{
    public class Role
    {
        public Role()
        {
            id = Guid.NewGuid().ToString();
            Permissions = new List<Permission>();

        }
        public string id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Permission> Permissions { get; set; }
    }
}

