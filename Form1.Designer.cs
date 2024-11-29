namespace WinFormsBMI2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            label5 = new Label();
            btnBMI = new Button();
            btnClear = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 75);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "ชื่อ - นามสกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 122);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 1;
            label2.Text = "อายุ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 174);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "ส่วนสูง ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 224);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "น้ำหนัก";
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(301, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(158, 122);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(176, 27);
            txtAge.TabIndex = 2;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(158, 174);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(176, 27);
            txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(158, 224);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(176, 27);
            txtWeight.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(396, 24);
            label5.Name = "label5";
            label5.Size = new Size(268, 35);
            label5.TabIndex = 8;
            label5.Text = "โปรแกรมคำนวณ ค่า BMI";
            // 
            // btnBMI
            // 
            btnBMI.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBMI.Location = new Point(823, 75);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(197, 60);
            btnBMI.TabIndex = 5;
            btnBMI.Text = "คำนวณ BMI";
            btnBMI.UseVisualStyleBackColor = true;
            btnBMI.Click += btnBMI_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(823, 182);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(197, 53);
            btnClear.TabIndex = 6;
            btnClear.Text = "เริ่มใหม่";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Coral;
            lblResult.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Black;
            lblResult.Location = new Point(107, 300);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(913, 286);
            lblResult.TabIndex = 11;
            lblResult.Text = "......";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1088, 612);
            Controls.Add(lblResult);
            Controls.Add(btnClear);
            Controls.Add(btnBMI);
            Controls.Add(label5);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "โปรแกรมคำนวณค่าBMI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label label5;
        private Button btnBMI;
        private Button btnClear;
        private Label lblResult;
    }
}
