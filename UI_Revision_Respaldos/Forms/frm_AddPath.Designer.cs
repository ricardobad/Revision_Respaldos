
namespace UI_Revision_Respaldos.Forms
{
    partial class frm_AddPath
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddPath));
            this.gpB_AddItem = new System.Windows.Forms.GroupBox();
            this.lbl_ServerSelect = new System.Windows.Forms.Label();
            this.lbl_NewPat = new System.Windows.Forms.Label();
            this.cmb_ServerSelect = new System.Windows.Forms.ComboBox();
            this.txt_UNCPath = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pcb_Save = new System.Windows.Forms.PictureBox();
            this.gpB_AddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Save)).BeginInit();
            this.SuspendLayout();
            // 
            // gpB_AddItem
            // 
            this.gpB_AddItem.BackColor = System.Drawing.Color.LightBlue;
            this.gpB_AddItem.Controls.Add(this.pcb_Save);
            this.gpB_AddItem.Controls.Add(this.btn_Save);
            this.gpB_AddItem.Controls.Add(this.txt_UNCPath);
            this.gpB_AddItem.Controls.Add(this.cmb_ServerSelect);
            this.gpB_AddItem.Controls.Add(this.lbl_NewPat);
            this.gpB_AddItem.Controls.Add(this.lbl_ServerSelect);
            this.gpB_AddItem.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpB_AddItem.Location = new System.Drawing.Point(12, 12);
            this.gpB_AddItem.Name = "gpB_AddItem";
            this.gpB_AddItem.Size = new System.Drawing.Size(1045, 312);
            this.gpB_AddItem.TabIndex = 0;
            this.gpB_AddItem.TabStop = false;
            this.gpB_AddItem.Text = "Add a new path";
            // 
            // lbl_ServerSelect
            // 
            this.lbl_ServerSelect.AutoSize = true;
            this.lbl_ServerSelect.Location = new System.Drawing.Point(6, 68);
            this.lbl_ServerSelect.Name = "lbl_ServerSelect";
            this.lbl_ServerSelect.Size = new System.Drawing.Size(210, 30);
            this.lbl_ServerSelect.TabIndex = 0;
            this.lbl_ServerSelect.Text = "Select Server Node";
            // 
            // lbl_NewPat
            // 
            this.lbl_NewPat.AutoSize = true;
            this.lbl_NewPat.Location = new System.Drawing.Point(6, 145);
            this.lbl_NewPat.Name = "lbl_NewPat";
            this.lbl_NewPat.Size = new System.Drawing.Size(381, 30);
            this.lbl_NewPat.TabIndex = 1;
            this.lbl_NewPat.Text = "Write UNC Path where file is located";
            // 
            // cmb_ServerSelect
            // 
            this.cmb_ServerSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ServerSelect.FormattingEnabled = true;
            this.cmb_ServerSelect.Location = new System.Drawing.Point(418, 65);
            this.cmb_ServerSelect.Name = "cmb_ServerSelect";
            this.cmb_ServerSelect.Size = new System.Drawing.Size(177, 38);
            this.cmb_ServerSelect.TabIndex = 2;
            // 
            // txt_UNCPath
            // 
            this.txt_UNCPath.Location = new System.Drawing.Point(418, 140);
            this.txt_UNCPath.Name = "txt_UNCPath";
            this.txt_UNCPath.Size = new System.Drawing.Size(593, 35);
            this.txt_UNCPath.TabIndex = 3;
            this.txt_UNCPath.Text = "\\\\example\\folder";
            this.txt_UNCPath.Click += new System.EventHandler(this.txt_UNCPath_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(809, 255);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(202, 51);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save Path";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // pcb_Save
            // 
            this.pcb_Save.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Save.Image")));
            this.pcb_Save.Location = new System.Drawing.Point(752, 255);
            this.pcb_Save.Name = "pcb_Save";
            this.pcb_Save.Size = new System.Drawing.Size(51, 51);
            this.pcb_Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Save.TabIndex = 7;
            this.pcb_Save.TabStop = false;
            // 
            // frm_AddPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 337);
            this.Controls.Add(this.gpB_AddItem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddPath";
            this.Load += new System.EventHandler(this.frm_AddPath_Load);
            this.gpB_AddItem.ResumeLayout(false);
            this.gpB_AddItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Save)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpB_AddItem;
        private System.Windows.Forms.ComboBox cmb_ServerSelect;
        private System.Windows.Forms.Label lbl_NewPat;
        private System.Windows.Forms.Label lbl_ServerSelect;
        private System.Windows.Forms.TextBox txt_UNCPath;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.PictureBox pcb_Save;
    }
}