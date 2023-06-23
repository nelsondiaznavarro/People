using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.CustomControls
{
    public abstract class MasterPage : ContentPage
    {
        public MasterPage()
        {
            var template = Application.Current.Resources["MasterTemplate"] as ControlTemplate;
            ControlTemplate =template;
        }
    }
}
