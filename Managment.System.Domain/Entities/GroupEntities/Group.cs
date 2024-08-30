using Managment.System.Domain.Entities.ScienceEntities;
using Managment.System.Domain.Entities.StudentEntities;
using Managment.System.Domain.Entities.UserEntities;

namespace Managment.System.Domain.Entities.GroupEntities;

public class Group : AudiTable
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
    public required User User { get; set; }
    public long UserId { get; set; }
    public ICollection<Student> Students { get; set; } = new List<Student>();
    public ICollection<Topic> Topics { get; set; } = new List<Topic>();
}
