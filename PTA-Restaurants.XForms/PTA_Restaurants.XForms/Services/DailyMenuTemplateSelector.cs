using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PTA_Restaurants.XForms.Services
{
    class DailyMenuTemplateSelector : Xamarin.Forms.DataTemplateSelector
    {
        private readonly DataTemplate headerDataTemplate;
        private readonly DataTemplate itemDataTemplate;

        public DailyMenuTemplateSelector()
        {
            this.headerDataTemplate = new DataTemplate(typeof(Views.ListHeaderViewCell));
            this.itemDataTemplate = new DataTemplate(typeof(Views.ListItemViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var dailyMenuItem = item as Models.DailyMenuDetail;
            if (dailyMenuItem == null)
                return null;
            return dailyMenuItem.isHeader ? this.headerDataTemplate : this.itemDataTemplate;
        }
    }
}
