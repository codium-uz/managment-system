namespace Managment.System.Domain.Entities.ScienceEntities;

public class TopicTask : AudiTable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
    public virtual Topic Topic { get; set; }
    public long TopicId { get; set; }
}
