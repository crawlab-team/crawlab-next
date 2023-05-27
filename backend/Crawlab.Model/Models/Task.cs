using Crawlab.Constant;
using Crawlab.Model.Base;
using Microsoft.EntityFrameworkCore;
using TaskStatus = Crawlab.Constant.TaskStatus;

namespace Crawlab.Model.Models;

[Index(nameof(Status))]
public class Task : BaseModel
{
    public string Mode { get; set; } = TaskMode.Random;
    public string Status { get; set; } = TaskStatus.Pending;
    public DateTime? StartedAt { get; set; }
    public DateTime? EndedAt { get; set; }

    public Node? Node { get; set; }
    public Spider? Spider { get; set; }
    public Schedule? Schedule { get; set; }
}