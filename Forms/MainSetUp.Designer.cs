namespace PointOfSale.Forms
{
    partial class MainSetUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSetUp));
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPayments
            // 
            this.btnPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPayments.Image = ((System.Drawing.Image)(resources.GetObject("btnPayments.Image")));
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPayments.Location = new System.Drawing.Point(238, 208);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(156, 111);
            this.btnPayments.TabIndex = 1;
            this.btnPayments.Text = "Payments";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnItems
            // 
            this.btnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnItems.Image = ((System.Drawing.Image)(resources.GetObject("btnItems.Image")));
            this.btnItems.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnItems.Location = new System.Drawing.Point(2, 208);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(156, 111);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = "Items";
            this.btnItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(2, 2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(156, 111);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(238, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 111);
            this.button1.TabIndex = 4;
            this.button1.Text = "Categories";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(734, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 79);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 529);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnPayments);
            this.Name = "MainSetUp";
            this.Text = "MainSetUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
    }
}