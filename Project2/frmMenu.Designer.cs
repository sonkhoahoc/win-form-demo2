
namespace Project2
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLNgườiKhaiBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.qLNgườiKhaiBáoToolStripMenuItem,
            this.qLNhânViênToolStripMenuItem,
            this.qLPhòngToolStripMenuItem,
            this.đăngNhậpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // qLNgườiKhaiBáoToolStripMenuItem
            // 
            this.qLNgườiKhaiBáoToolStripMenuItem.Name = "qLNgườiKhaiBáoToolStripMenuItem";
            this.qLNgườiKhaiBáoToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.qLNgườiKhaiBáoToolStripMenuItem.Text = "QL Người Khai Báo";
            this.qLNgườiKhaiBáoToolStripMenuItem.Click += new System.EventHandler(this.qLNgườiKhaiBáoToolStripMenuItem_Click);
            // 
            // qLNhânViênToolStripMenuItem
            // 
            this.qLNhânViênToolStripMenuItem.Name = "qLNhânViênToolStripMenuItem";
            this.qLNhânViênToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.qLNhânViênToolStripMenuItem.Text = "QL Nhân Viên";
            this.qLNhânViênToolStripMenuItem.Click += new System.EventHandler(this.qLNhânViênToolStripMenuItem_Click);
            // 
            // qLPhòngToolStripMenuItem
            // 
            this.qLPhòngToolStripMenuItem.Name = "qLPhòngToolStripMenuItem";
            this.qLPhòngToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.qLPhòngToolStripMenuItem.Text = "QL Phòng";
            this.qLPhòngToolStripMenuItem.Click += new System.EventHandler(this.qLPhòngToolStripMenuItem_Click);
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "7uu ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLNgườiKhaiBáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}