namespace MYSQL
{
    partial class Form1
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
            this.dgv_premier = new System.Windows.Forms.DataGridView();
            this.cmbBox_nationality = new System.Windows.Forms.ComboBox();
            this.label_valueMember = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.cmbBox_teamName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_premier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_premier
            // 
            this.dgv_premier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_premier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_premier.Location = new System.Drawing.Point(-1, 85);
            this.dgv_premier.Name = "dgv_premier";
            this.dgv_premier.Size = new System.Drawing.Size(804, 371);
            this.dgv_premier.TabIndex = 0;
            // 
            // cmbBox_nationality
            // 
            this.cmbBox_nationality.FormattingEnabled = true;
            this.cmbBox_nationality.Location = new System.Drawing.Point(13, 13);
            this.cmbBox_nationality.Name = "cmbBox_nationality";
            this.cmbBox_nationality.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_nationality.TabIndex = 1;
            this.cmbBox_nationality.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_valueMember
            // 
            this.label_valueMember.AutoSize = true;
            this.label_valueMember.Location = new System.Drawing.Point(13, 41);
            this.label_valueMember.Name = "label_valueMember";
            this.label_valueMember.Size = new System.Drawing.Size(77, 13);
            this.label_valueMember.TabIndex = 2;
            this.label_valueMember.Text = "Value member:";
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Location = new System.Drawing.Point(96, 41);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(13, 13);
            this.label_value.TabIndex = 3;
            this.label_value.Text = "?";
            // 
            // cmbBox_teamName
            // 
            this.cmbBox_teamName.FormattingEnabled = true;
            this.cmbBox_teamName.Location = new System.Drawing.Point(667, 12);
            this.cmbBox_teamName.Name = "cmbBox_teamName";
            this.cmbBox_teamName.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_teamName.TabIndex = 4;
            this.cmbBox_teamName.SelectedIndexChanged += new System.EventHandler(this.cmbBox_teamName_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbBox_teamName);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.label_valueMember);
            this.Controls.Add(this.cmbBox_nationality);
            this.Controls.Add(this.dgv_premier);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_premier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_premier;
        private System.Windows.Forms.ComboBox cmbBox_nationality;
        private System.Windows.Forms.Label label_valueMember;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.ComboBox cmbBox_teamName;
    }
}

