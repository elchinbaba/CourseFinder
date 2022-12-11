
namespace CourseFinder
{
    partial class CourseFinder
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
            this.cBoxCategory = new System.Windows.Forms.ComboBox();
            this.cBoxBudget = new System.Windows.Forms.ComboBox();
            this.cBoxRegime = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.pBoxInstitution = new System.Windows.Forms.PictureBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblRegime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxInstitution)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxCategory
            // 
            this.cBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCategory.FormattingEnabled = true;
            this.cBoxCategory.Items.AddRange(new object[] {
            "programming",
            "business",
            "language"});
            this.cBoxCategory.Location = new System.Drawing.Point(129, 92);
            this.cBoxCategory.Name = "cBoxCategory";
            this.cBoxCategory.Size = new System.Drawing.Size(276, 33);
            this.cBoxCategory.TabIndex = 0;
            // 
            // cBoxBudget
            // 
            this.cBoxBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxBudget.FormattingEnabled = true;
            this.cBoxBudget.Items.AddRange(new object[] {
            "low",
            "mid",
            "high"});
            this.cBoxBudget.Location = new System.Drawing.Point(129, 169);
            this.cBoxBudget.Name = "cBoxBudget";
            this.cBoxBudget.Size = new System.Drawing.Size(276, 33);
            this.cBoxBudget.TabIndex = 1;
            // 
            // cBoxRegime
            // 
            this.cBoxRegime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxRegime.FormattingEnabled = true;
            this.cBoxRegime.Items.AddRange(new object[] {
            "online",
            "offline",
            "hybrid"});
            this.cBoxRegime.Location = new System.Drawing.Point(129, 253);
            this.cBoxRegime.Name = "cBoxRegime";
            this.cBoxRegime.Size = new System.Drawing.Size(276, 33);
            this.cBoxRegime.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(172, 334);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(138, 58);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(557, 136);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(93, 25);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "institution";
            this.lblResult.Visible = false;
            // 
            // pBoxInstitution
            // 
            this.pBoxInstitution.Cursor = System.Windows.Forms.Cursors.Default;
            this.pBoxInstitution.Location = new System.Drawing.Point(482, 199);
            this.pBoxInstitution.Name = "pBoxInstitution";
            this.pBoxInstitution.Size = new System.Drawing.Size(244, 146);
            this.pBoxInstitution.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxInstitution.TabIndex = 5;
            this.pBoxInstitution.TabStop = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(24, 95);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 25);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(42, 172);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(74, 25);
            this.lblBudget.TabIndex = 7;
            this.lblBudget.Text = "Budget";
            // 
            // lblRegime
            // 
            this.lblRegime.AutoSize = true;
            this.lblRegime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegime.Location = new System.Drawing.Point(38, 256);
            this.lblRegime.Name = "lblRegime";
            this.lblRegime.Size = new System.Drawing.Size(78, 25);
            this.lblRegime.TabIndex = 8;
            this.lblRegime.Text = "Regime";
            // 
            // CourseFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRegime);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.pBoxInstitution);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cBoxRegime);
            this.Controls.Add(this.cBoxBudget);
            this.Controls.Add(this.cBoxCategory);
            this.Name = "CourseFinder";
            this.Text = "Find Course";
            this.Load += new System.EventHandler(this.CourseFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxInstitution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxCategory;
        private System.Windows.Forms.ComboBox cBoxBudget;
        private System.Windows.Forms.ComboBox cBoxRegime;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pBoxInstitution;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblRegime;
    }
}

