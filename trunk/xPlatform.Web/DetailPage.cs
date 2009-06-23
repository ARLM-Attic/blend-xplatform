using System;
using xPlatform;
using System.Web;
using System.Web.UI;
using System.Reflection;
using System.Web.UI.WebControls;

namespace xPlatform.Web
{
    [Serializable]
    public partial class DetailPage : Page
    {
        [NonSerialized]
        protected const int MinimumLength = 8;

        protected Repeater detailMenu;

        protected string GenerateRandomName(int length)
        {
            if (length < MinimumLength)
                length = MinimumLength;

            Random random = new Random();
            string result = String.Empty;

            for (int i = 0; i < length; i++)
                result = String.Concat(result, (char)random.Next((int)'a', (int)'z'));

            return result;
        }

        protected string GenerateRandomName()
        {
            return GenerateRandomName(MinimumLength);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string assemblyName = (this.Request.QueryString["assemblyName"] ?? String.Empty).Trim();
                AppDomain dynamicDomain = AppDomain.CreateDomain(GenerateRandomName());
                Assembly targetAssembly = dynamicDomain.Load(assemblyName);

                if (targetAssembly == null)
                    throw new Exception("Invalid Assembly Name Specified.");

                foreach (Type eachType in targetAssembly.GetTypes())
                {
                }
            }
            catch (Exception throwedException)
            {
                this.Response.Write(String.Format("<pre>{0}</pre>", throwedException.ToString()));
                this.Response.Redirect("~/", true);
            }
        }
    }
}
