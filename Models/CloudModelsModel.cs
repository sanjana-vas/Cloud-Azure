// Models/CloudModelsModel.cs
namespace k213375_cloud.Models
{
    public class CloudModelsModel
    {
        public string Title { get; set; } = "Cloud Computing Models";
        public List<string> Models { get; set; } = new List<string>
        {
            "Infrastructure as a Service (IaaS)",
            "Platform as a Service (PaaS)",
            "Software as a Service (SaaS)"
        };
    }
}
