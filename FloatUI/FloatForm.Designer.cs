namespace FloatUI
{
    partial class FloatForm
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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.GroupBox groupBox3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.value_input = new System.Windows.Forms.TextBox();
            this.float_result = new System.Windows.Forms.TextBox();
            this.float_result_bits = new System.Windows.Forms.TextBox();
            this.double_result_bits = new System.Windows.Forms.TextBox();
            this.double_result = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.value_input);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(600, 60);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter your value here:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 12);
            label1.TabIndex = 0;
            label1.Text = "Value:";
            // 
            // value_input
            // 
            this.value_input.Location = new System.Drawing.Point(81, 21);
            this.value_input.Name = "value_input";
            this.value_input.Size = new System.Drawing.Size(513, 21);
            this.value_input.TabIndex = 1;
            this.value_input.TextChanged += new System.EventHandler(this.OnInputValueChanged);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.float_result_bits);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(this.float_result);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new System.Drawing.Point(27, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(600, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Float Result:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 12);
            label2.TabIndex = 0;
            label2.Text = "Float:";
            // 
            // float_result
            // 
            this.float_result.Enabled = false;
            this.float_result.Location = new System.Drawing.Point(81, 29);
            this.float_result.Name = "float_result";
            this.float_result.Size = new System.Drawing.Size(513, 21);
            this.float_result.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(22, 65);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 12);
            label3.TabIndex = 2;
            label3.Text = "Bits:";
            // 
            // float_result_bits
            // 
            this.float_result_bits.Enabled = false;
            this.float_result_bits.Location = new System.Drawing.Point(81, 62);
            this.float_result_bits.Name = "float_result_bits";
            this.float_result_bits.Size = new System.Drawing.Size(513, 21);
            this.float_result_bits.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(this.double_result_bits);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(this.double_result);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new System.Drawing.Point(27, 208);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(600, 100);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Double Result:";
            // 
            // double_result_bits
            // 
            this.double_result_bits.Enabled = false;
            this.double_result_bits.Location = new System.Drawing.Point(81, 62);
            this.double_result_bits.Name = "double_result_bits";
            this.double_result_bits.Size = new System.Drawing.Size(513, 21);
            this.double_result_bits.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 65);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(35, 12);
            label4.TabIndex = 2;
            label4.Text = "Bits:";
            // 
            // double_result
            // 
            this.double_result.Enabled = false;
            this.double_result.Location = new System.Drawing.Point(81, 29);
            this.double_result.Name = "double_result";
            this.double_result.Size = new System.Drawing.Size(513, 21);
            this.double_result.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(20, 32);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 12);
            label5.TabIndex = 0;
            label5.Text = "Double:";
            // 
            // FloatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 539);
            this.Controls.Add(groupBox3);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FloatForm";
            this.Text = "FloatForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox value_input;
        private System.Windows.Forms.TextBox float_result_bits;
        private System.Windows.Forms.TextBox float_result;
        private System.Windows.Forms.TextBox double_result_bits;
        private System.Windows.Forms.TextBox double_result;
    }
}