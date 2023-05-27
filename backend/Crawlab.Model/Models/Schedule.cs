using Crawlab.Model.Base;

namespace Crawlab.Model.Models;

public class Schedule : BaseModel
{
    public string Cron { get; set; } = string.Empty;
    public Spider Spider { get; set; } = new();
}