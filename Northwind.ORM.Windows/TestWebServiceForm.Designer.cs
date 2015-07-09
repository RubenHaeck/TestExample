namespace Northwind.ORM.Windows
{
    partial class TestWebServiceForm
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
            this.btnSecureTestService = new System.Windows.Forms.Button();
            this.btnTestService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSecureTestService
            // 
            this.btnSecureTestService.Location = new System.Drawing.Point(12, 12);
            this.btnSecureTestService.Name = "btnSecureTestService";
            this.btnSecureTestService.Size = new System.Drawing.Size(75, 41);
            this.btnSecureTestService.TabIndex = 0;
            this.btnSecureTestService.Text = "SecureTestService";
            this.btnSecureTestService.UseVisualStyleBackColor = true;
            this.btnSecureTestService.Click += new System.EventHandler(this.btnSecureTestService_Click);
            // 
            // btnTestService
            // 
            this.btnTestService.Location = new System.Drawing.Point(12, 84);
            this.btnTestService.Name = "btnTestService";
            this.btnTestService.Size = new System.Drawing.Size(75, 41);
            this.btnTestService.TabIndex = 0;
            this.btnTestService.Text = "TestService";
            this.btnTestService.UseVisualStyleBackColor = true;
            this.btnTestService.Click += new System.EventHandler(this.btnTestService_Click);
            // 
            // TestWebServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnTestService);
            this.Controls.Add(this.btnSecureTestService);
            this.Name = "TestWebServiceForm";
            this.Text = "TestWebServiceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSecureTestService;
        private System.Windows.Forms.Button btnTestService;
    }
}