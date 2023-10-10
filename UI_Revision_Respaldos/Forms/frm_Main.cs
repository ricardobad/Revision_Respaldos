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
        //borrar resize
        private void frm_Main_Resize(object sender, EventArgs e)
        {

        }

        #region Events


        #endregion

        #region Methods

        private void cargarCmb(ref cls_add_items_DAL obj_item) 
        {
            Obj_It.aServers = new string[tbControl.TabCount];
            for(int i =0; i<tbControl.TabCount; i++)
            {
                Obj_It.aServers[i] = tbControl.TabPages[i].Text;           
            }
            frm_add.cmbLoad(ref obj_item);
            Obj_DAL.sErrorMsj = "hello";

        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            Obj_BLL.obtenerInfo(ref Obj_DAL);

            MessageBox.Show("Resultado \n"+ Obj_DAL.sFile + Obj_DAL.sFileDate);
        }

        private void tls_btn_item1_Click(object sender, EventArgs e)
        {
            //Add item procedure
            
            frm_add.Show();
            


        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            cargarCmb(ref Obj_It);
        }
    }
}
