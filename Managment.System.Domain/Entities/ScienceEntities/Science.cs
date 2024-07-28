using System.ComponentModel.DataAnnotations;

namespace Managment.System.Domain.Entities.ScienceEntities;

public class Science : AudiTable
{
    [Required]
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public virtual ICollection<Topic> Topics { get; set; }
}
