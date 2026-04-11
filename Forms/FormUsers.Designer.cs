namespace PointOfSale.Forms
{
    partial class FormUsers
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSelect = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.lblReceiptLine2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblReceiptLine1 = new System.Windows.Forms.Label();
            this.txtJobDes = new System.Windows.Forms.TextBox();
            this.lblJobDes = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblResetAdderss2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblResetAddress1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblResetName = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(46, 46);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelect,
            this.btnNew,
            this.btnSave,
            this.btnFirst,
            this.btnBack,
            this.btnNext,
            this.btnLast,
            this.btnExit,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(981, 73);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSelect
            // 
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(53, 70);
            this.btnSelect.Text = "Select";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 70);
            this.btnNew.Text = "New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 70);
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(50, 70);
            this.btnFirst.Text = "First";
            this.btnFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 70);
            this.btnBack.Text = "Back";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 70);
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(50, 70);
            this.btnLast.Text = "Last";
            this.btnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 70);
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 73);
            // 
            // txtPhone1
            // 
            this.txtPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone1.Location = new System.Drawing.Point(602, 160);
            this.txtPhone1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(333, 27);
            this.txtPhone1.TabIndex = 43;
            // 
            // lblReceiptLine2
            // 
            this.lblReceiptLine2.AutoSize = true;
            this.lblReceiptLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptLine2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReceiptLine2.Location = new System.Drawing.Point(520, 163);
            this.lblReceiptLine2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiptLine2.Name = "lblReceiptLine2";
            this.lblReceiptLine2.Size = new System.Drawing.Size(61, 20);
            this.lblReceiptLine2.TabIndex = 42;
            this.lblReceiptLine2.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(602, 101);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(333, 27);
            this.txtEmail.TabIndex = 41;
            // 
            // lblReceiptLine1
            // 
            this.lblReceiptLine1.AutoSize = true;
            this.lblReceiptLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptLine1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReceiptLine1.Location = new System.Drawing.Point(520, 106);
            this.lblReceiptLine1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiptLine1.Name = "lblReceiptLine1";
            this.lblReceiptLine1.Size = new System.Drawing.Size(56, 20);
            this.lblReceiptLine1.TabIndex = 40;
            this.lblReceiptLine1.Text = "Email";
            // 
            // txtJobDes
            // 
            this.txtJobDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobDes.Location = new System.Drawing.Point(176, 274);
            this.txtJobDes.Margin = new System.Windows.Forms.Padding(4);
            this.txtJobDes.Name = "txtJobDes";
            this.txtJobDes.Size = new System.Drawing.Size(333, 27);
            this.txtJobDes.TabIndex = 37;
            // 
            // lblJobDes
            // 
            this.lblJobDes.AutoSize = true;
            this.lblJobDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJobDes.Location = new System.Drawing.Point(11, 279);
            this.lblJobDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobDes.Name = "lblJobDes";
            this.lblJobDes.Size = new System.Drawing.Size(79, 20);
            this.lblJobDes.TabIndex = 36;
            this.lblJobDes.Text = "Job Des";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(176, 217);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(333, 27);
            this.txtFullName.TabIndex = 35;
            // 
            // lblResetAdderss2
            // 
            this.lblResetAdderss2.AutoSize = true;
            this.lblResetAdderss2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetAdderss2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResetAdderss2.Location = new System.Drawing.Point(11, 222);
            this.lblResetAdderss2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResetAdderss2.Name = "lblResetAdderss2";
            this.lblResetAdderss2.Size = new System.Drawing.Size(88, 20);
            this.lblResetAdderss2.TabIndex = 34;
            this.lblResetAdderss2.Text = "FullName";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(176, 160);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(333, 27);
            this.txtPassword.TabIndex = 33;
            // 
            // lblResetAddress1
            // 
            this.lblResetAddress1.AutoSize = true;
            this.lblResetAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetAddress1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResetAddress1.Location = new System.Drawing.Point(11, 165);
            this.lblResetAddress1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResetAddress1.Name = "lblResetAddress1";
            this.lblResetAddress1.Size = new System.Drawing.Size(91, 20);
            this.lblResetAddress1.TabIndex = 32;
            this.lblResetAddress1.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(176, 103);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(333, 27);
            this.txtUserName.TabIndex = 31;
            // 
            // lblResetName
            // 
            this.lblResetName.AutoSize = true;
            this.lblResetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResetName.Location = new System.Drawing.Point(11, 108);
            this.lblResetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResetName.Name = "lblResetName";
            this.lblResetName.Size = new System.Drawing.Size(103, 20);
            this.lblResetName.TabIndex = 30;
            this.lblResetName.Text = "User Name";
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 353);
            this.Controls.Add(this.txtPhone1);
            this.Controls.Add(this.lblReceiptLine2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblReceiptLine1);
            this.Controls.Add(this.txtJobDes);
            this.Controls.Add(this.lblJobDes);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblResetAdderss2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblResetAddress1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblResetName);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormUsers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSelect;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label lblReceiptLine2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblReceiptLine1;
        private System.Windows.Forms.TextBox txtJobDes;
        private System.Windows.Forms.Label lblJobDes;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblResetAdderss2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblResetAddress1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblResetName;
    }
}