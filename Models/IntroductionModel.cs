// Models/IntroductionModel.cs
namespace k213375_cloud.Models
{
    public class IntroductionModel
    {
        public string Title { get; set; } = "Introduction to Cloud Computing";
        public List<string> Benefits { get; set; } = new List<string>
        {
            "Scalability",
            "Cost Efficiency",
            "Flexibility",
            "Accessibility",
            "Security"
        };
    }
}
