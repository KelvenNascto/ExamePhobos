using EnxamePhobos.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamePhobos.UI.adm
{
    public partial class ManageAdm : System.Web.UI.Page
    {
        UsuarioBLL userBLL = new UsuarioBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGv1();
            LoadDbl1();
        }

        //popular gv1
        public void LoadGv1()
        {
            gv1.DataSource = userBLL.GetUserBLL();
            gv1.DataBind();
        }

        //popular ddl1
        public void LoadDbl1()
        {
            ddl1.DataSource = userBLL.GetTypeUserBLL();
            ddl1.DataBind();
        }

        //ValidaPage
        public bool ValidaPage()
        {
            bool valid;
            DateTime dt;

            return true;
        }

        //record
        protected void btnRecord_Click(object sender, EventArgs e)
        {

        }

        //Clear
        protected void btnClear_Click(object sender, EventArgs e)
        {

        }

        //Delete
        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        //Search
        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        //Search gv1
        protected void gv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}