using System;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace xPlatform.Web
{
    [Serializable]
    public partial class DefaultPage : Page
    {
        protected Repeater mainMenu;

        protected virtual DataTable MakeupMainMenu()
        {
            DataTable table = new DataTable();

            table.Columns.AddRange(new DataColumn[] {
                new DataColumn("Index", typeof(int)),
                new DataColumn("Title", typeof(string)),
                new DataColumn("Description", typeof(string)),
                new DataColumn("AssemblyName", typeof(string)),
            });

            int count = 0;

            foreach (object[] eachRow in new object[][] {
                new object[] { ++count, "ADVAPI32.DLL", "Microsoft(R) Windows(R) 운영 체제의 ADVAPI32.DLL 모듈 정보를 탐색합니다.", "xPlatform.advapi32" },
                new object[] { ++count, "COMCTL32.DLL", "Microsoft(R) Windows(R) 운영 체제의 COMCTL32.DLL 모듈 정보를 탐색합니다.", "xPlatform.comctl32" },
                new object[] { ++count, "GDI32.DLL", "Microsoft(R) Windows(R) 운영 체제의 GDI32.DLL 모듈 정보를 탐색합니다.", "xPlatform.gdi32" },
                new object[] { ++count, "KERNEL32.DLL", "Microsoft(R) Windows(R) 운영 체제의 KERNEL32.DLL 모듈 정보를 탐색합니다.", "xPlatform.kernel32" },
                new object[] { ++count, "MSFTEDIT.DLL", "Microsoft(R) Windows(R) 운영 체제의 MSFTEDIT.DLL 모듈 정보를 탐색합니다.", "xPlatform.msftedit" },
                new object[] { ++count, "MSVCRT.DLL", "Microsoft(R) Visual C++(R) 개발 도구의 MSVCRT.DLL 모듈 정보를 탐색합니다.", "xPlatform.msvcrt" },
                new object[] { ++count, "PSAPI.DLL", "Microsoft(R) Windows(R) 운영 체제의 PSAPI.DLL 모듈 정보를 탐색합니다.", "xPlatform.psapi" },
                new object[] { ++count, "SECUR32.DLL", "Microsoft(R) Windows(R) 운영 체제의 SECUR32.DLL 모듈 정보를 탐색합니다.", "xPlatform.secur32" },
                new object[] { ++count, "USER32.DLL", "Microsoft(R) Windows(R) 운영 체제의 USER32.DLL 모듈 정보를 탐색합니다.", "xPlatform.user32" },
                new object[] { ++count, "WINSPOOL.DRV", "Microsoft(R) Windows(R) 운영 체제의 WINSPOOL.DRV 모듈 정보를 탐색합니다.", "xPlatform.winspool" },
            })
                table.Rows.Add(eachRow);

            return table;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.mainMenu != null)
            {
                this.mainMenu.ItemDataBound += new RepeaterItemEventHandler(mainMenu_ItemDataBound);
                this.mainMenu.DataSource = this.MakeupMainMenu();
                this.mainMenu.DataBind();
            }
        }

        private void mainMenu_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType.Equals(ListItemType.Item) ||
                e.Item.ItemType.Equals(ListItemType.AlternatingItem))
            {
                Label index = e.Item.FindControl("Index") as Label;
                HyperLink title = e.Item.FindControl("Title") as HyperLink;
                Label description = e.Item.FindControl("Description") as Label;
                Label assemblyName = e.Item.FindControl("AssemblyName") as Label;
                DataRow eachRow = e.Item.DataItem as DataRow;

                if (eachRow == null)
                    return;

                if (index != null)
                    index.Text = ((int)eachRow["Index"]).ToString();

                if (title != null)
                {
                    title.Text = (string)eachRow["Title"];
                    title.NavigateUrl = String.Format("~/Detail.aspx?assembly={0}", (string)eachRow["AssemblyName"]);
                }

                if (description != null)
                    description.Text = (string)eachRow["Description"];

                if (assemblyName != null)
                    assemblyName.Text = String.Format("~/Detail.aspx?assembly={0}", (string)eachRow["AssemblyName"]);
            }
        }
    }
}
