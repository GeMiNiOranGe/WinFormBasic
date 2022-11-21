namespace WinFormBasic {
    partial class frmMainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.btnSumSeries = new System.Windows.Forms.Button();
            this.btnSum2Para = new System.Windows.Forms.Button();
            this.btnCheckMFO = new System.Windows.Forms.Button();
            this.btnAddName = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSumSeries
            // 
            this.btnSumSeries.Location = new System.Drawing.Point(12, 12);
            this.btnSumSeries.Name = "btnSumSeries";
            this.btnSumSeries.Size = new System.Drawing.Size(77, 48);
            this.btnSumSeries.TabIndex = 0;
            this.btnSumSeries.Text = "Tính Tổng\r\n1 chuỗi\r\n";
            this.btnSumSeries.UseVisualStyleBackColor = true;
            this.btnSumSeries.Click += new System.EventHandler(this.btnSumSeries_Click);
            // 
            // btnSum2Para
            // 
            this.btnSum2Para.Location = new System.Drawing.Point(95, 12);
            this.btnSum2Para.Name = "btnSum2Para";
            this.btnSum2Para.Size = new System.Drawing.Size(77, 48);
            this.btnSum2Para.TabIndex = 0;
            this.btnSum2Para.Text = "Tính 2 tham số";
            this.btnSum2Para.UseVisualStyleBackColor = true;
            this.btnSum2Para.Click += new System.EventHandler(this.btnSum2Para_Click);
            // 
            // btnCheckMFO
            // 
            this.btnCheckMFO.Location = new System.Drawing.Point(178, 12);
            this.btnCheckMFO.Name = "btnCheckMFO";
            this.btnCheckMFO.Size = new System.Drawing.Size(77, 48);
            this.btnCheckMFO.TabIndex = 0;
            this.btnCheckMFO.Text = "Kiểm tra giới tính";
            this.btnCheckMFO.UseVisualStyleBackColor = true;
            this.btnCheckMFO.Click += new System.EventHandler(this.btnCheckMFO_Click);
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(261, 12);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(77, 48);
            this.btnAddName.TabIndex = 0;
            this.btnAddName.Text = "Thêm tên";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(178, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 144);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.btnCheckMFO);
            this.Controls.Add(this.btnSum2Para);
            this.Controls.Add(this.btnSumSeries);
            this.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retarded project";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSumSeries;
        private System.Windows.Forms.Button btnSum2Para;
        private System.Windows.Forms.Button btnCheckMFO;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}