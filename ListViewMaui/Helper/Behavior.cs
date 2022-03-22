using Syncfusion.Maui.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    public class Behavior : Behavior<Syncfusion.Maui.ListView.SfListView>
    {
        #region Fields

        private Syncfusion.Maui.ListView.SfListView ListView;

        #endregion

        #region Overrides
        protected override void OnAttachedTo(Syncfusion.Maui.ListView.SfListView bindable)
        {
            ListView = bindable;
            ListView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
            {
                PropertyName = "ContactName",
                KeySelector = (object obj1) =>
                {
                    var item = (obj1 as ListViewContactInfo);
                    return item.ContactName[0].ToString();
                },
            });
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Syncfusion.Maui.ListView.SfListView bindable)
        {
            ListView = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion
    }
}
