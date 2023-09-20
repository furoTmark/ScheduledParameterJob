using System.Web.UI;

namespace ScheduledParameterJob.Parameters
{
    public class ParameterControlDTO
    {
        public string Id => Control.ID;
        public bool ShowLabel => !string.IsNullOrEmpty(LabelText);
        public string LabelText { get; set; }
        public string Description { get; set; }
        public Control Control { get; set; }
    }
}
