using System.ComponentModel.DataAnnotations;

namespace Managment.System.Domain.Entities;

public class BaseEntity
{
    [Key]
    public long Id { get; set; }
}
