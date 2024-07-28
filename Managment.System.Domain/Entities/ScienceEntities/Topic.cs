namespace Managment.System.Domain.Entities.ScienceEntities;

public class Topic : AudiTable
{
    public string Name { get; set; }
    public string Title { get; set; }
    public DateTime? Date { get; set; }
    public long ScienceId { get; set; }
    public virtual Science? Science { get; set; }
    public virtual ICollection<TopicTask> Tasks { get; set; }
}
