using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Revision_Respaldos.Settings;
using BLL_Revision_Respaldos.Settings;

namespace UI_Revision_Respaldos.Forms
{
    public partial class frm_AddPath : Form
    {
        public frm_AddPath()
        {
            InitializeComponent();
        }

        #region Global
        cls_add_items_DAL obj_it = new cls_add_items_DAL();
        cls_settings_DAL obj_DAL = new cls_settings_DAL();
        cls_settings_BLL obj_bll = new cls_settings_BLL();
        #endregion
        private void frm_AddPath_Load(object sender, EventArgs e)
        {
            
        }

        public void cmbLoad(ref cls_add_items_DAL DAL_items ) 
        {
            cmb_ServerSelect.Items.Clear();

            //CARGA de tabs de acuerdo a lo que vaya agregando el user
            //for(int i = 0; i< DAL_items.aServers.Length; i++)
            //{
            //    cmb_ServerSelect.Items.Add(DAL_items.aServers[i]);
            //}

            
        }

        private void txt_UNCPath_Click(object sender, EventArgs e)
        {
            txt_UNCPath.Text = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //check file extension
            if (txt_UNCPath.Text.Contains(".dat")|| txt_UNCPath.Text.Contains(".bak"))
            {
                testConnection(ref obj_DAL);
                //if not exist errors, close window and add path window
                if (obj_DAL.sErrorMsj == "")
                {
                    //add path window  AQUI SE LLAMA AL METODO QUE MANDA EL INFO
                    //DEL DATATABLE al DATAGRID VIEW
                }
            }
            else
            
            {
                
                MessageBox.Show("Debe escribir la ruta completa del archivo incluyendo la extension " +
                    "del archivo  (.dat, .bak) ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            

        }

        private void testConnection(ref cls_settings_DAL OBJ_DAL) 
        {
            OBJ_DAL.sSharedPath = txt_UNCPath.Text.Trim();
            obj_bll.obtenerInfo(ref OBJ_DAL);
            if (obj_DAL.sErrorMsj == "")
            {
                obj_bll.readFile(ref OBJ_DAL);
                
            }

            if (obj_DAL.sErrorMsj == "") 
            {
                obj_bll.addFolders(ref OBJ_DAL);

                if (obj_DAL.sErrorMsj == "")
                {
                    MessageBox.Show("Resultado: \n " + obj_DAL.sFile + "\n" + obj_DAL.sFileDate);
                }
                else 
                {
                    MessageBox.Show(obj_DAL.sErrorMsj, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }

            else
            {
                MessageBox.Show(obj_DAL.sErrorMsj, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
