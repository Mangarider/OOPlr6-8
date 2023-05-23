using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOPlr6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mark_more = new System.Windows.Forms.CheckBox();
            this.ctrl_enabled = new System.Windows.Forms.CheckBox();
            this.group_figures = new System.Windows.Forms.GroupBox();
            this.rad_square = new System.Windows.Forms.RadioButton();
            this.rad_triangle = new System.Windows.Forms.RadioButton();
            this.rad_circle = new System.Windows.Forms.RadioButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.group_figures.SuspendLayout();
            this.SuspendLayout();
            // 
            // mark_more
            // 
            this.mark_more.AutoSize = true;
            this.mark_more.Location = new System.Drawing.Point(5, 105);
            this.mark_more.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mark_more.Name = "mark_more";
            this.mark_more.Size = new System.Drawing.Size(92, 20);
            this.mark_more.TabIndex = 0;
            this.mark_more.Text = "Mul circles";
            this.mark_more.UseVisualStyleBackColor = true;
            // 
            // ctrl_enabled
            // 
            this.ctrl_enabled.AutoSize = true;
            this.ctrl_enabled.Location = new System.Drawing.Point(5, 122);
            this.ctrl_enabled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrl_enabled.Name = "ctrl_enabled";
            this.ctrl_enabled.Size = new System.Drawing.Size(125, 20);
            this.ctrl_enabled.TabIndex = 1;
            this.ctrl_enabled.Text = "Control Enabled";
            this.ctrl_enabled.UseVisualStyleBackColor = true;
            // 
            // group_figures
            // 
            this.group_figures.Controls.Add(this.rad_square);
            this.group_figures.Controls.Add(this.rad_triangle);
            this.group_figures.Controls.Add(this.rad_circle);
            this.group_figures.Location = new System.Drawing.Point(1, 2);
            this.group_figures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_figures.Name = "group_figures";
            this.group_figures.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_figures.Size = new System.Drawing.Size(160, 98);
            this.group_figures.TabIndex = 2;
            this.group_figures.TabStop = false;
            this.group_figures.Text = "Figures";
            // 
            // rad_square
            // 
            this.rad_square.AutoSize = true;
            this.rad_square.Location = new System.Drawing.Point(22, 69);
            this.rad_square.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rad_square.Name = "rad_square";
            this.rad_square.Size = new System.Drawing.Size(72, 20);
            this.rad_square.TabIndex = 3;
            this.rad_square.Text = "Square";
            this.rad_square.UseVisualStyleBackColor = true;
            // 
            // rad_triangle
            // 
            this.rad_triangle.AutoSize = true;
            this.rad_triangle.Location = new System.Drawing.Point(22, 45);
            this.rad_triangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rad_triangle.Name = "rad_triangle";
            this.rad_triangle.Size = new System.Drawing.Size(78, 20);
            this.rad_triangle.TabIndex = 2;
            this.rad_triangle.Text = "Triangle";
            this.rad_triangle.UseVisualStyleBackColor = true;
            // 
            // rad_circle
            // 
            this.rad_circle.AutoSize = true;
            this.rad_circle.Checked = true;
            this.rad_circle.Location = new System.Drawing.Point(22, 21);
            this.rad_circle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rad_circle.Name = "rad_circle";
            this.rad_circle.Size = new System.Drawing.Size(62, 20);
            this.rad_circle.TabIndex = 0;
            this.rad_circle.TabStop = true;
            this.rad_circle.Text = "Circle";
            this.rad_circle.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(5, 146);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(266, 179);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 572);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.group_figures);
            this.Controls.Add(this.ctrl_enabled);
            this.Controls.Add(this.mark_more);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.group_figures.ResumeLayout(false);
            this.group_figures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox mark_more;
        private CheckBox ctrl_enabled;
        private GroupBox group_figures;
        private RadioButton rad_square;
        private RadioButton rad_triangle;
        private RadioButton rad_circle;
        private TreeView treeView1;
    }
}