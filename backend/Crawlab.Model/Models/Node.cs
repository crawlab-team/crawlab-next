using Crawlab.Constant;
using Crawlab.Model.Base;
using Microsoft.EntityFrameworkCore;

namespace Crawlab.Model.Models;

[Index(nameof(Status))]
public class Node : BaseModel
{
    public string Status { get; set; } = NodeStatus.Online;
    public bool Enabled { get; set; } = true;
    public int MaxRunners { get; set; } = 32;
}