using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingUI
{
    public class MainViewViewModel
    {
        private ExternalCommandData _commandData;

        public MainViewViewModel(ExternalCommandData commandData)
        {
            _commandData = commandData;
        }
    }
}
