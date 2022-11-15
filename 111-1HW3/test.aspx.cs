using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string[] sa_dc = new string[2] { "蔬菜", "水果" };
        string[,] sa_df = new string[2, 2] { { "A菜", "空心菜" },{ "番茄", "火龍果" } };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                for (int i_ct = 0; i_ct < sa_dc.Length; i_ct++)
                {
                    ListItem o_l = new ListItem();
                    o_l.Text = o_l.Value = sa_dc[i_ct];

                    ddl_Category.Items.Add(o_l);
                }
                mt_ddl();
            }

        }

        protected void ddl_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            mt_ddl();
        }
        protected void mt_ddl() {
            int i_dc = ddl_Category.SelectedIndex;
           ddl_Food.Items.Clear();
            for (int i_ct = 0; i_ct < sa_df.GetLength(1); i_ct++)
            {
                ListItem o_l = new ListItem();
                o_l.Text = o_l.Value = sa_df[i_dc, i_ct];

                ddl_Food.Items.Add(o_l);
            }
        }
    }
}