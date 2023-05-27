using Crawlab.Model.Base;
using Crawlab.Model.Models;

namespace Crawlab.Model.Relations;

public class SpiderNode : BaseModel
{
    public string SpiderId { get; set; } = string.Empty;
    public string NodeId { get; set; } = string.Empty;

    public Spider? Spider { get; set; }
    public Node? Node { get; set; }
}