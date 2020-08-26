namespace WindowsFormsApp2
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtBoxNum1 = new System.Windows.Forms.TextBox();
            this.txtBoxNum2 = new System.Windows.Forms.TextBox();
            this.lblWebSrvTest = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(186, 144);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(106, 25);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Number1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(186, 187);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(106, 25);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Number2";
            // 
            // txtBoxNum1
            // 
            this.txtBoxNum1.Location = new System.Drawing.Point(323, 144);
            this.txtBoxNum1.Name = "txtBoxNum1";
            this.txtBoxNum1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNum1.TabIndex = 2;
            // 
            // txtBoxNum2
            // 
            this.txtBoxNum2.Location = new System.Drawing.Point(323, 187);
            this.txtBoxNum2.Name = "txtBoxNum2";
            this.txtBoxNum2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNum2.TabIndex = 3;
            // 
            // lblWebSrvTest
            // 
            this.lblWebSrvTest.AutoSize = true;
            this.lblWebSrvTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebSrvTest.Location = new System.Drawing.Point(225, 97);
            this.lblWebSrvTest.Name = "lblWebSrvTest";
            this.lblWebSrvTest.Size = new System.Drawing.Size(198, 25);
            this.lblWebSrvTest.TabIndex = 4;
            this.lblWebSrvTest.Text = "Web Service Test";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(191, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 59);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(323, 253);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(101, 59);
            this.btnSubtract.TabIndex = 6;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(191, 327);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(101, 59);
            this.btnMultiply.TabIndex = 7;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(323, 327);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(101, 59);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblWebSrvTest);
            this.Controls.Add(this.txtBoxNum2);
            this.Controls.Add(this.txtBoxNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtBoxNum1;
        private System.Windows.Forms.TextBox txtBoxNum2;
        private System.Windows.Forms.Label lblWebSrvTest;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
    }
}

