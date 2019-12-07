using System.ComponentModel;

namespace milktea
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(milktea.frmMain));
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tbntType = new System.Windows.Forms.ToolStripButton();
            this.manageTool = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.managePill = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnTableStatus = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 67);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(520, 383);
            this.flpTable.TabIndex = 1;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 33);
            this.panel1.TabIndex = 2;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripButton1, this.toolStripButton2, this.tbntType});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(520, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolTable";
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image) (resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Tăng dần";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image) (resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Giảm dần";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            this.tbntType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbntType.Image = ((System.Drawing.Image) (resources.GetObject("tbntType.Image")));
            this.tbntType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbntType.Name = "tbntType";
            this.tbntType.Size = new System.Drawing.Size(23, 22);
            this.tbntType.Text = "Theo loại";
            this.tbntType.Click += new System.EventHandler(this.toolStripButton3_Click);
            this.manageTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.manageMenu, this.manageEmp, this.managePill});
            this.manageTool.Name = "manageTool";
            this.manageTool.Size = new System.Drawing.Size(62, 20);
            this.manageTool.Text = "Quản trị";
            this.manageMenu.Image = ((System.Drawing.Image) (resources.GetObject("manageMenu.Image")));
            this.manageMenu.Name = "manageMenu";
            this.manageMenu.Size = new System.Drawing.Size(128, 22);
            this.manageMenu.Text = "Thự đơn";
            this.manageEmp.Image = ((System.Drawing.Image) (resources.GetObject("manageEmp.Image")));
            this.manageEmp.Name = "manageEmp";
            this.manageEmp.Size = new System.Drawing.Size(128, 22);
            this.manageEmp.Text = "Nhân viên";
            this.managePill.Image = ((System.Drawing.Image) (resources.GetObject("managePill.Image")));
            this.managePill.Name = "managePill";
            this.managePill.Size = new System.Drawing.Size(128, 22);
            this.managePill.Text = "Hóa đơn";
            this.giúpĐỡToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.about});
            this.giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            this.giúpĐỡToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.giúpĐỡToolStripMenuItem.Text = "Giúp đỡ";
            this.about.Image = ((System.Drawing.Image) (resources.GetObject("about.Image")));
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(125, 22);
            this.about.Text = "Thông tin";
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.manageTool, this.giúpĐỡToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.pnTableStatus.Location = new System.Drawing.Point(538, 67);
            this.pnTableStatus.Name = "pnTableStatus";
            this.pnTableStatus.Size = new System.Drawing.Size(334, 383);
            this.pnTableStatus.TabIndex = 3;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(538, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 32);
            this.panel3.TabIndex = 4;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nguyễn KIên Trung";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbTime.Location = new System.Drawing.Point(12, 456);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(187, 22);
            this.lbTime.TabIndex = 5;
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnTableStatus);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milkteak";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Panel pnTableStatus;
        private System.Windows.Forms.ToolStripMenuItem manageTool;
        private System.Windows.Forms.ToolStripMenuItem managePill;
        private System.Windows.Forms.ToolStripMenuItem manageMenu;
        private System.Windows.Forms.ToolStripMenuItem manageEmp;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripButton tbntType;
    }
}