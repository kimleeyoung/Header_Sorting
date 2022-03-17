namespace HeaderSort
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
            this.IvCall = new System.Windows.Forms.ListView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chPhone = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // IvCall
            // 
            this.IvCall.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPhone});
            this.IvCall.GridLines = true;
            this.IvCall.Location = new System.Drawing.Point(12, 12);
            this.IvCall.Name = "IvCall";
            this.IvCall.Size = new System.Drawing.Size(250, 206);
            this.IvCall.TabIndex = 0;
            this.IvCall.UseCompatibleStateImageBehavior = false;
            this.IvCall.View = System.Windows.Forms.View.Details;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblName.Location = new System.Drawing.Point(12, 234);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 271);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 15);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "전화번호";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(73, 231);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(108, 23);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(73, 268);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(108, 23);
            this.txtPhone.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(187, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 65);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "입력";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 100;
            // 
            // chPhone
            // 
            this.chPhone.Text = "전화번호";
            this.chPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPhone.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 307);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.IvCall);
            this.Name = "Form1";
            this.Text = "헤더정렬";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView IvCall;
        private Label lblName;
        private Label lblPhone;
        private ColumnHeader chName;
        private ColumnHeader chPhone;
        private TextBox txtName;
        private TextBox txtPhone;
        private Button btnSave;
    }
}