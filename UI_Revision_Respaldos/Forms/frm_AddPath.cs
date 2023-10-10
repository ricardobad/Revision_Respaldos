﻿using System;
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

            for(int i = 0; i< DAL_items.aServers.Length; i++)
            {
                cmb_ServerSelect.Items.Add(DAL_items.aServers[i]);
            }

            
        }

        private void txt_UNCPath_Click(object sender, EventArgs e)
        {
            txt_UNCPath.Text = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //obj_DAL.sSharedPath = txt_UNCPath.Text;
            //obj_it.bFlag = Convert.ToByte(cmb_ServerSelect.SelectedIndex);

            //if user didn't click Test Connection before Save Button, test connection before save it
            testConnection(ref obj_DAL);

        }

        private void testConnection(ref cls_settings_DAL OBJ_DAL) 
        {
            OBJ_DAL.sSharedPath = txt_UNCPath.Text.Trim();
            obj_bll.obtenerInfo(ref OBJ_DAL);
            MessageBox.Show("Resultado: \n "+ OBJ_DAL.sFile + "\n" + OBJ_DAL.sFileDate);

        }
    }
}
