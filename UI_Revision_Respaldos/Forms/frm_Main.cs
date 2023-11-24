using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Revision_Respaldos.Settings;
using DAL_Revision_Respaldos.Settings;



namespace UI_Revision_Respaldos.Forms
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        #region global

        cls_settings_BLL Obj_BLL = new cls_settings_BLL();
        cls_settings_DAL Obj_DAL = new cls_settings_DAL();
        cls_add_items_DAL Obj_It = new cls_add_items_DAL();
        frm_AddPath frm_add = new frm_AddPath();

        #endregion

        #region Events


        #endregion

        #region Methods

        private void loadDataGridView(ref cls_settings_BLL obj_BLL) 
        {
            dgv_Rutas.DataSource = null;

        }
        private void cargarCmb(ref cls_add_items_DAL obj_item) 
        {
            //CARGA TABS
            //Obj_It.aServers = new string[tbControl.TabCount];
            //for(int i =0; i<tbControl.TabCount; i++)
            //{
            //    Obj_It.aServers[i] = tbControl.TabPages[i].Text;           
            //}
            //frm_add.cmbLoad(ref obj_item);
            //Obj_DAL.sErrorMsj = "hello";

        }
        #endregion

        private void tls_Menu_Click(object sender, EventArgs e)
        {
            //Add item method
            frm_add.Show();
        }
        

        private void frm_Main_Load(object sender, EventArgs e)
        {
            cargarCmb(ref Obj_It);
        }

        
    }
}
