
namespace Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnMu = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCle = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMul = new System.Windows.Forms.RadioButton();
            this.rdSub = new System.Windows.Forms.RadioButton();
            this.rdadd = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMu
            // 
            this.btnMu.Location = new System.Drawing.Point(540, 275);
            this.btnMu.Name = "btnMu";
            this.btnMu.Size = new System.Drawing.Size(165, 78);
            this.btnMu.TabIndex = 1;
            this.btnMu.Text = "Multiply";
            this.btnMu.UseVisualStyleBackColor = true;
            this.btnMu.Click += new System.EventHandler(this.btnMu_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(69, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 78);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCle
            // 
            this.btnCle.Location = new System.Drawing.Point(245, 390);
            this.btnCle.Name = "btnCle";
            this.btnCle.Size = new System.Drawing.Size(165, 78);
            this.btnCle.TabIndex = 2;
            this.btnCle.Text = "Clear";
            this.btnCle.UseVisualStyleBackColor = true;
            this.btnCle.Click += new System.EventHandler(this.btnCle_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(315, 275);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(165, 78);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "Subtract";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Number:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(210, 44);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(125, 27);
            this.txt1.TabIndex = 6;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(210, 101);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(125, 27);
            this.txt2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Second Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdMul);
            this.groupBox1.Controls.Add(this.rdSub);
            this.groupBox1.Controls.Add(this.rdadd);
            this.groupBox1.Location = new System.Drawing.Point(551, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 143);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose an arithmetic operation";
            // 
            // rdMul
            // 
            this.rdMul.AutoSize = true;
            this.rdMul.Location = new System.Drawing.Point(17, 87);
            this.rdMul.Name = "rdMul";
            this.rdMul.Size = new System.Drawing.Size(146, 24);
            this.rdMul.TabIndex = 2;
            this.rdMul.TabStop = true;
            this.rdMul.Text = "I want to multiply";
            this.rdMul.UseVisualStyleBackColor = true;
            // 
            // rdSub
            // 
            this.rdSub.AutoSize = true;
            this.rdSub.Location = new System.Drawing.Point(17, 57);
            this.rdSub.Name = "rdSub";
            this.rdSub.Size = new System.Drawing.Size(151, 24);
            this.rdSub.TabIndex = 1;
            this.rdSub.TabStop = true;
            this.rdSub.Text = "I want to substract";
            this.rdSub.UseVisualStyleBackColor = true;
            // 
            // rdadd
            // 
            this.rdadd.AutoSize = true;
            this.rdadd.Location = new System.Drawing.Point(17, 27);
            this.rdadd.Name = "rdadd";
            this.rdadd.Size = new System.Drawing.Size(118, 24);
            this.rdadd.TabIndex = 0;
            this.rdadd.TabStop = true;
            this.rdadd.Text = "I want to add";
            this.rdadd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCle);
            this.Controls.Add(this.btnMu);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCle;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdMul;
        private System.Windows.Forms.RadioButton rdSub;
        private System.Windows.Forms.RadioButton rdadd;
        private System.Windows.Forms.TextBox txt2;
    }
}

