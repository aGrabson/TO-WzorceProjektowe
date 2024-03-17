using System.ComponentModel.DataAnnotations;

namespace WzorceProjektowe.API.Entities
{
    public abstract class BaseDbItem
    {
        [Key]
        public Guid Id { get; set; }
    }
}
