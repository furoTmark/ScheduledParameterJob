using System.Collections.Generic;
using System.Web.UI;

namespace ScheduledParameterJob.Parameters
{
    public interface IParameterDefinitions
    {
        IEnumerable<ParameterControlDTO> GetParameterControls();
        void SetValue(Control control, object value);
        object GetValue(Control control);
    }
}
