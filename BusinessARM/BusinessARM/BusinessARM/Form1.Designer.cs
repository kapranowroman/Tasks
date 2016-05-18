namespace BusinessARM
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtBoxGuid = new System.Windows.Forms.TextBox();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.txtBoxProductGroupID = new System.Windows.Forms.TextBox();
            this.txtBoxUnitID = new System.Windows.Forms.TextBox();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            this.txtBoxMoney = new System.Windows.Forms.TextBox();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 173);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtBoxGuid
            // 
            this.txtBoxGuid.Location = new System.Drawing.Point(250, 48);
            this.txtBoxGuid.Name = "txtBoxGuid";
            this.txtBoxGuid.Size = new System.Drawing.Size(100, 20);
            this.txtBoxGuid.TabIndex = 1;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(250, 74);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDescription.TabIndex = 2;
            // 
            // txtBoxProductGroupID
            // 
            this.txtBoxProductGroupID.Location = new System.Drawing.Point(250, 100);
            this.txtBoxProductGroupID.Name = "txtBoxProductGroupID";
            this.txtBoxProductGroupID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProductGroupID.TabIndex = 3;
            // 
            // txtBoxUnitID
            // 
            this.txtBoxUnitID.Location = new System.Drawing.Point(250, 126);
            this.txtBoxUnitID.Name = "txtBoxUnitID";
            this.txtBoxUnitID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUnitID.TabIndex = 4;
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.Location = new System.Drawing.Point(250, 152);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.txtBoxWeight.TabIndex = 5;
            // 
            // txtBoxMoney
            // 
            this.txtBoxMoney.Location = new System.Drawing.Point(250, 178);
            this.txtBoxMoney.Name = "txtBoxMoney";
            this.txtBoxMoney.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMoney.TabIndex = 6;
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.Location = new System.Drawing.Point(250, 204);
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQuantity.TabIndex = 7;
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(229, 230);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbUnit.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 597);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.txtBoxMoney);
            this.Controls.Add(this.txtBoxWeight);
            this.Controls.Add(this.txtBoxUnitID);
            this.Controls.Add(this.txtBoxProductGroupID);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.txtBoxGuid);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtBoxGuid;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.TextBox txtBoxProductGroupID;
        private System.Windows.Forms.TextBox txtBoxUnitID;
        private System.Windows.Forms.TextBox txtBoxWeight;
        private System.Windows.Forms.TextBox txtBoxMoney;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.ComboBox cmbUnit;
    }
}

