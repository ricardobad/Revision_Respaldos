
namespace UI_Revision_Respaldos.Forms
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.fLP_autoResize = new System.Windows.Forms.FlowLayoutPanel();
            this.tls_Menu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tls_btn_item1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOrEditPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbP_Mourin = new System.Windows.Forms.TabPage();
            this.tbP_226 = new System.Windows.Forms.TabPage();
            this.tbP_230 = new System.Windows.Forms.TabPage();
            this.tbP_Nodos = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.fLP_autoResize.SuspendLayout();
            this.tls_Menu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tbP_Nodos.SuspendLayout();
            this.SuspendLayout();
            // 
            // fLP_autoResize
            // 
            this.fLP_autoResize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fLP_autoResize.AutoScroll = true;
            this.fLP_autoResize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fLP_autoResize.Controls.Add(this.tls_Menu);
            this.fLP_autoResize.Location = new System.Drawing.Point(3, 2);
            this.fLP_autoResize.Name = "fLP_autoResize";
            this.fLP_autoResize.Size = new System.Drawing.Size(1240, 50);
            this.fLP_autoResize.TabIndex = 2;
            // 
            // tls_Menu
            // 
            this.tls_Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.tls_Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tls_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.tls_Menu.Location = new System.Drawing.Point(0, 0);
            this.tls_Menu.Name = "tls_Menu";
            this.tls_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tls_Menu.Size = new System.Drawing.Size(112, 34);
            this.tls_Menu.TabIndex = 0;
            this.tls_Menu.Text = "tls_Menu";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tls_btn_item1,
            this.deleteOrEditPathToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(94, 29);
            this.toolStripButton1.Text = "Settings";
            // 
            // tls_btn_item1
            // 
            this.tls_btn_item1.Name = "tls_btn_item1";
            this.tls_btn_item1.Size = new System.Drawing.Size(260, 34);
            this.tls_btn_item1.Text = "Add Path";
            this.tls_btn_item1.Click += new System.EventHandler(this.tls_btn_item1_Click);
            // 
            // deleteOrEditPathToolStripMenuItem
            // 
            this.deleteOrEditPathToolStripMenuItem.Name = "deleteOrEditPathToolStripMenuItem";
            this.deleteOrEditPathToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.deleteOrEditPathToolStripMenuItem.Text = "Delete or edit Path";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(147, 29);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbControl);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1065, 583);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbP_Mourin);
            this.tbControl.Controls.Add(this.tbP_226);
            this.tbControl.Controls.Add(this.tbP_230);
            this.tbControl.Controls.Add(this.tbP_Nodos);
            this.tbControl.Location = new System.Drawing.Point(3, 3);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(1054, 571);
            this.tbControl.TabIndex = 0;
            // 
            // tbP_Mourin
            // 
            this.tbP_Mourin.Location = new System.Drawing.Point(4, 29);
            this.tbP_Mourin.Name = "tbP_Mourin";
            this.tbP_Mourin.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_Mourin.Size = new System.Drawing.Size(1046, 538);
            this.tbP_Mourin.TabIndex = 0;
            this.tbP_Mourin.Text = "172.27.25.23";
            this.tbP_Mourin.UseVisualStyleBackColor = true;
            // 
            // tbP_226
            // 
            this.tbP_226.Location = new System.Drawing.Point(4, 29);
            this.tbP_226.Name = "tbP_226";
            this.tbP_226.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_226.Size = new System.Drawing.Size(1046, 538);
            this.tbP_226.TabIndex = 1;
            this.tbP_226.Text = "32.226";
            this.tbP_226.UseVisualStyleBackColor = true;
            // 
            // tbP_230
            // 
            this.tbP_230.Location = new System.Drawing.Point(4, 29);
            this.tbP_230.Name = "tbP_230";
            this.tbP_230.Size = new System.Drawing.Size(1046, 538);
            this.tbP_230.TabIndex = 2;
            this.tbP_230.Text = "32.230";
            this.tbP_230.UseVisualStyleBackColor = true;
            // 
            // tbP_Nodos
            // 
            this.tbP_Nodos.Controls.Add(this.button1);
            this.tbP_Nodos.Location = new System.Drawing.Point(4, 29);
            this.tbP_Nodos.Name = "tbP_Nodos";
            this.tbP_Nodos.Size = new System.Drawing.Size(1046, 538);
            this.tbP_Nodos.TabIndex = 3;
            this.tbP_Nodos.Text = "Nodos_BCCR";
            this.tbP_Nodos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 642);
            this.Controls.Add(this.fLP_autoResize);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Main";
            this.Text = "Backup Checker";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.Resize += new System.EventHandler(this.frm_Main_Resize);
            this.fLP_autoResize.ResumeLayout(false);
            this.fLP_autoResize.PerformLayout();
            this.tls_Menu.ResumeLayout(false);
            this.tls_Menu.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tbControl.ResumeLayout(false);
            this.tbP_Nodos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLP_autoResize;
        private System.Windows.Forms.ToolStrip tls_Menu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem tls_btn_item1;
        private System.Windows.Forms.ToolStripMenuItem deleteOrEditPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbP_Mourin;
        private System.Windows.Forms.TabPage tbP_226;
        private System.Windows.Forms.TabPage tbP_230;
        private System.Windows.Forms.TabPage tbP_Nodos;
        private System.Windows.Forms.Button button1;
    }
}