
namespace PDFPasswordRemover
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Input_File_Select_Panel = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Input_File_Select_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Mode_Choosing_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Mode_Choosing_Description = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Password_Enter_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_File_Select_Panel)).BeginInit();
            this.Input_File_Select_Panel.Panel1.SuspendLayout();
            this.Input_File_Select_Panel.Panel2.SuspendLayout();
            this.Input_File_Select_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Mode_Choosing_Panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Password_Enter_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.75F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1331, 678);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Input_File_Select_Panel);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(902, 439);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Input_File_Select_Panel
            // 
            this.Input_File_Select_Panel.Location = new System.Drawing.Point(3, 3);
            this.Input_File_Select_Panel.Name = "Input_File_Select_Panel";
            this.Input_File_Select_Panel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Input_File_Select_Panel.Panel1
            // 
            this.Input_File_Select_Panel.Panel1.Controls.Add(this.label3);
            // 
            // Input_File_Select_Panel.Panel2
            // 
            this.Input_File_Select_Panel.Panel2.Controls.Add(this.splitContainer2);
            this.Input_File_Select_Panel.Size = new System.Drawing.Size(363, 80);
            this.Input_File_Select_Panel.SplitterDistance = 33;
            this.Input_File_Select_Panel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select a PDF with password";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Input_File_Select_Button);
            this.splitContainer2.Size = new System.Drawing.Size(363, 43);
            this.splitContainer2.SplitterDistance = 291;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 35);
            this.textBox2.TabIndex = 1;
            // 
            // Input_File_Select_Button
            // 
            this.Input_File_Select_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Input_File_Select_Button.Location = new System.Drawing.Point(0, 0);
            this.Input_File_Select_Button.Name = "Input_File_Select_Button";
            this.Input_File_Select_Button.Size = new System.Drawing.Size(68, 43);
            this.Input_File_Select_Button.TabIndex = 0;
            this.Input_File_Select_Button.Text = "...";
            this.Input_File_Select_Button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Mode_Choosing_Panel);
            this.panel1.Location = new System.Drawing.Point(372, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 126);
            this.panel1.TabIndex = 2;
            // 
            // Mode_Choosing_Panel
            // 
            this.Mode_Choosing_Panel.Controls.Add(this.Mode_Choosing_Description);
            this.Mode_Choosing_Panel.Controls.Add(this.comboBox1);
            this.Mode_Choosing_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mode_Choosing_Panel.Location = new System.Drawing.Point(0, 0);
            this.Mode_Choosing_Panel.Name = "Mode_Choosing_Panel";
            this.Mode_Choosing_Panel.Size = new System.Drawing.Size(301, 126);
            this.Mode_Choosing_Panel.TabIndex = 3;
            // 
            // Mode_Choosing_Description
            // 
            this.Mode_Choosing_Description.AutoSize = true;
            this.Mode_Choosing_Description.Location = new System.Drawing.Point(3, 0);
            this.Mode_Choosing_Description.Name = "Mode_Choosing_Description";
            this.Mode_Choosing_Description.Size = new System.Drawing.Size(274, 48);
            this.Mode_Choosing_Description.TabIndex = 2;
            this.Mode_Choosing_Description.Text = "Choose which password you know.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Userpassword",
            "Ownerpassword",
            "Without password"});
            this.comboBox1.Location = new System.Drawing.Point(3, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Password_Enter_Panel);
            this.panel2.Location = new System.Drawing.Point(3, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 126);
            this.panel2.TabIndex = 3;
            // 
            // Password_Enter_Panel
            // 
            this.Password_Enter_Panel.Controls.Add(this.label2);
            this.Password_Enter_Panel.Controls.Add(this.textBox1);
            this.Password_Enter_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password_Enter_Panel.Location = new System.Drawing.Point(0, 0);
            this.Password_Enter_Panel.Name = "Password_Enter_Panel";
            this.Password_Enter_Panel.Size = new System.Drawing.Size(277, 126);
            this.Password_Enter_Panel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 678);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Input_File_Select_Panel.Panel1.ResumeLayout(false);
            this.Input_File_Select_Panel.Panel1.PerformLayout();
            this.Input_File_Select_Panel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Input_File_Select_Panel)).EndInit();
            this.Input_File_Select_Panel.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Mode_Choosing_Panel.ResumeLayout(false);
            this.Mode_Choosing_Panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Password_Enter_Panel.ResumeLayout(false);
            this.Password_Enter_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Input_File_Select_Button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel Mode_Choosing_Panel;
        private System.Windows.Forms.Label Mode_Choosing_Description;
        private System.Windows.Forms.SplitContainer Input_File_Select_Panel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel Password_Enter_Panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

