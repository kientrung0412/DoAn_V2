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
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.thựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnTrịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 27);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(559, 423);
            this.flpTable.TabIndex = 1;
            // 
            // thựcĐơnToolStripMenuItem
            // 
            this.thựcĐơnToolStripMenuItem.Name = "thựcĐơnToolStripMenuItem";
            this.thựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thựcĐơnToolStripMenuItem.Text = "Thực đơn";
            // 
            // quảnTrịToolStripMenuItem
            // 
            this.quảnTrịToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuToolStripMenuItem, this.nhânViênToolStripMenuItem, this.hóaĐơnToolStripMenuItem});
            this.quảnTrịToolStripMenuItem.Name = "quảnTrịToolStripMenuItem";
            this.quảnTrịToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quảnTrịToolStripMenuItem.Text = "Quản trị";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // giúpĐỡToolStripMenuItem
            // 
            this.giúpĐỡToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.thôngTinToolStripMenuItem});
            this.giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            this.giúpĐỡToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.giúpĐỡToolStripMenuItem.Text = "Giúp đỡ";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.thựcĐơnToolStripMenuItem, this.quảnTrịToolStripMenuItem, this.giúpĐỡToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Milkteak";
            this.UseWaitCursor = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnTrịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thựcĐơnToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
    }
}