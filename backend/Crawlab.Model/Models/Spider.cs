using Crawlab.Constant;
using Crawlab.Model.Base;
using Crawlab.Model.Relations;

namespace Crawlab.Model.Models;

public class Spider : BaseModel
{
    public string Mode { get; set; } = TaskMode.Random;

    public List<SpiderNode> SpiderNodes { get; set; } = new();
    public List<Spider> Spiders { get; set; } = new();
}