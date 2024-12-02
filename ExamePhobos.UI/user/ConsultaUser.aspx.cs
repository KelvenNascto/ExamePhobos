using EnxamePhobos.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnxamePhobos.UI.user
{
    public partial class ConsultaUser : System.Web.UI.Page
    {
        UsuarioBLL userBLL = new UsuarioBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGv1();
        }

        //popular gv1
        public void LoadGv1()
        {
            gv1.DataSource = userBLL.GetUserBLL();
            gv1.DataBind();
        }
    }
}