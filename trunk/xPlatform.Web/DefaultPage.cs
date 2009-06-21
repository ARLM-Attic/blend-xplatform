using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace xPlatform.Web
{
    [Serializable]
    public partial class DefaultPage : Page
    {
        protected Repeater itemRepeater;

        public Repeater ItemRepeater
        {
            get { return this.itemRepeater; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}
