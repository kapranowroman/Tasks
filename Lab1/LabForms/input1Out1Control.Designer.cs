namespace LabForms
{
    partial class input1Out1Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.lblTask2 = new System.Windows.Forms.Label();
            this.lblTextRes = new System.Windows.Forms.Label();
            this.lblTextInput = new System.Windows.Forms.Label();
            this.txtTask2 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTask2);
            this.groupBox2.Controls.Add(this.lblTask2);
            this.groupBox2.Controls.Add(this.lblTextRes);
            this.groupBox2.Controls.Add(this.lblTextInput);
            this.groupBox2.Controls.Add(this.txtTask2);
            this.groupBox2.Location = new System.Drawing.Point(5, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 53);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задача №2";
            // 
            // btnTask2
            // 
            this.btnTask2.Location = new System.Drawing.Point(331, 16);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(75, 23);
            this.btnTask2.TabIndex = 4;
            this.btnTask2.Text = "Рассчитать";
            this.btnTask2.UseVisualStyleBackColor = true;
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
            // 
            // lblTask2
            // 
            this.lblTask2.AutoSize = true;
            this.lblTask2.Location = new System.Drawing.Point(535, 23);
            this.lblTask2.Name = "lblTask2";
            this.lblTask2.Size = new System.Drawing.Size(10, 13);
            this.lblTask2.TabIndex = 3;
            this.lblTask2.Text = " ";
            // 
            // lblTextRes
            // 
            this.lblTextRes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTextRes.AutoSize = true;
            this.lblTextRes.Location = new System.Drawing.Point(429, 23);
            this.lblTextRes.Name = "lblTextRes";
            this.lblTextRes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTextRes.Size = new System.Drawing.Size(45, 13);
            this.lblTextRes.TabIndex = 2;
            this.lblTextRes.Text = "Объем:";
            this.lblTextRes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTextInput
            // 
            this.lblTextInput.AutoSize = true;
            this.lblTextInput.Location = new System.Drawing.Point(6, 23);
            this.lblTextInput.Name = "lblTextInput";
            this.lblTextInput.Size = new System.Drawing.Size(154, 13);
            this.lblTextInput.TabIndex = 1;
            this.lblTextInput.Text = "Введите значение радиуса R";
            // 
            // txtTask2
            // 
            this.txtTask2.Location = new System.Drawing.Point(235, 18);
            this.txtTask2.Name = "txtTask2";
            this.txtTask2.Size = new System.Drawing.Size(66, 20);
            this.txtTask2.TabIndex = 0;
            this.txtTask2.Text = "0";
            // 
            // MyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "MyControl";
            this.Size = new System.Drawing.Size(620, 57);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTask2;
        private System.Windows.Forms.Label lblTask2;
        private System.Windows.Forms.Label lblTextInput;
        private System.Windows.Forms.TextBox txtTask2;
        protected System.Windows.Forms.Label lblTextRes;

    }
}
