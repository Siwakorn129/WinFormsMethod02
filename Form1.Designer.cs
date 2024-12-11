namespace WinFormsMethod02
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            btnCircleArea = new Button();
            txtRadius = new TextBox();
            lblResult = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtOutputParameter = new Button();
            txtInput = new TextBox();
            txtRefParameter = new Button();
            btnTriangle01 = new Button();
            txtSize = new TextBox();
            txtLetter = new TextBox();
            txtOutput = new TextBox();
            btnArrayParameter = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightCyan;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            groupBox1.Location = new Point(83, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(853, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "รูปวงกลม";
            // 
            // button2
            // 
            button2.Location = new Point(483, 73);
            button2.Name = "button2";
            button2.Size = new Size(160, 52);
            button2.TabIndex = 4;
            button2.Text = "เส้นรอบวง";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(366, 73);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(111, 52);
            btnCircleArea.TabIndex = 3;
            btnCircleArea.Text = "พื้นที่";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(195, 74);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(159, 51);
            txtRadius.TabIndex = 2;
            txtRadius.TextAlign = HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.Window;
            lblResult.Location = new Point(195, 164);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(355, 72);
            lblResult.TabIndex = 1;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 80);
            label1.Name = "label1";
            label1.Size = new Size(123, 44);
            label1.TabIndex = 0;
            label1.Text = "รัศมีวงกลม";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Pink;
            groupBox2.Controls.Add(txtOutputParameter);
            groupBox2.Controls.Add(txtInput);
            groupBox2.Controls.Add(txtRefParameter);
            groupBox2.Controls.Add(btnTriangle01);
            groupBox2.Controls.Add(txtSize);
            groupBox2.Controls.Add(txtLetter);
            groupBox2.Controls.Add(txtOutput);
            groupBox2.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            groupBox2.Location = new Point(83, 328);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1117, 423);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ทดสอบ function";
            // 
            // txtOutputParameter
            // 
            txtOutputParameter.Location = new Point(755, 339);
            txtOutputParameter.Name = "txtOutputParameter";
            txtOutputParameter.Size = new Size(333, 58);
            txtOutputParameter.TabIndex = 6;
            txtOutputParameter.Text = "ทดสอบ output parameter";
            txtOutputParameter.UseVisualStyleBackColor = true;
            txtOutputParameter.Click += txtOutputParameter_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(560, 262);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(362, 51);
            txtInput.TabIndex = 5;
            // 
            // txtRefParameter
            // 
            txtRefParameter.Location = new Point(400, 339);
            txtRefParameter.Name = "txtRefParameter";
            txtRefParameter.Size = new Size(333, 58);
            txtRefParameter.TabIndex = 4;
            txtRefParameter.Text = "ทดสอบ reference parameter";
            txtRefParameter.UseVisualStyleBackColor = true;
            txtRefParameter.Click += txtRefParameter_Click;
            // 
            // btnTriangle01
            // 
            btnTriangle01.Location = new Point(611, 50);
            btnTriangle01.Name = "btnTriangle01";
            btnTriangle01.Size = new Size(140, 70);
            btnTriangle01.TabIndex = 3;
            btnTriangle01.Text = "Triangle";
            btnTriangle01.UseVisualStyleBackColor = true;
            btnTriangle01.Click += btnTriangle01_Click;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(400, 133);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(172, 51);
            txtSize.TabIndex = 2;
            // 
            // txtLetter
            // 
            txtLetter.Location = new Point(400, 50);
            txtLetter.Name = "txtLetter";
            txtLetter.Size = new Size(172, 51);
            txtLetter.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(55, 50);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(317, 329);
            txtOutput.TabIndex = 0;
            // 
            // btnArrayParameter
            // 
            btnArrayParameter.Font = new Font("Segoe UI", 20F);
            btnArrayParameter.Location = new Point(1023, 45);
            btnArrayParameter.Name = "btnArrayParameter";
            btnArrayParameter.Size = new Size(340, 77);
            btnArrayParameter.TabIndex = 2;
            btnArrayParameter.Text = "parameter แบบ array";
            btnArrayParameter.UseVisualStyleBackColor = true;
            btnArrayParameter.Click += btnArrayParameter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1487, 763);
            Controls.Add(btnArrayParameter);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Windows Forms Method(Function)";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button btnCircleArea;
        private TextBox txtRadius;
        private Label lblResult;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtOutput;
        private Button btnTriangle01;
        private TextBox txtSize;
        private TextBox txtLetter;
        private Button txtRefParameter;
        private TextBox txtInput;
        private Button txtOutputParameter;
        private Button btnArrayParameter;
    }
}
