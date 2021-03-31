
namespace InfoSaugumasPD3
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
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptTxt = new System.Windows.Forms.TextBox();
            this.pTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.decryptedTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nTxt = new System.Windows.Forms.TextBox();
            this.encryptedTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(138, 537);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(90, 32);
            this.encryptBtn.TabIndex = 0;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(138, 585);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(90, 32);
            this.decryptBtn.TabIndex = 1;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text to cypher:";
            // 
            // encryptTxt
            // 
            this.encryptTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptTxt.Location = new System.Drawing.Point(12, 32);
            this.encryptTxt.Multiline = true;
            this.encryptTxt.Name = "encryptTxt";
            this.encryptTxt.Size = new System.Drawing.Size(347, 112);
            this.encryptTxt.TabIndex = 3;
            // 
            // pTxt
            // 
            this.pTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTxt.Location = new System.Drawing.Point(44, 466);
            this.pTxt.Name = "pTxt";
            this.pTxt.Size = new System.Drawing.Size(95, 26);
            this.pTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "p:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "q:";
            // 
            // qTxt
            // 
            this.qTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qTxt.Location = new System.Drawing.Point(44, 498);
            this.qTxt.Name = "qTxt";
            this.qTxt.Size = new System.Drawing.Size(95, 26);
            this.qTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Decrypted text:";
            // 
            // decryptedTxt
            // 
            this.decryptedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedTxt.Location = new System.Drawing.Point(12, 334);
            this.decryptedTxt.Multiline = true;
            this.decryptedTxt.Name = "decryptedTxt";
            this.decryptedTxt.ReadOnly = true;
            this.decryptedTxt.Size = new System.Drawing.Size(347, 112);
            this.decryptedTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "n:";
            // 
            // nTxt
            // 
            this.nTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTxt.Location = new System.Drawing.Point(264, 466);
            this.nTxt.Name = "nTxt";
            this.nTxt.Size = new System.Drawing.Size(95, 26);
            this.nTxt.TabIndex = 11;
            // 
            // encryptedTxt
            // 
            this.encryptedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedTxt.Location = new System.Drawing.Point(12, 177);
            this.encryptedTxt.Multiline = true;
            this.encryptedTxt.Name = "encryptedTxt";
            this.encryptedTxt.ReadOnly = true;
            this.encryptedTxt.Size = new System.Drawing.Size(347, 112);
            this.encryptedTxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Encrypted text:";
            // 
            // eTxt
            // 
            this.eTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eTxt.Location = new System.Drawing.Point(264, 498);
            this.eTxt.Name = "eTxt";
            this.eTxt.Size = new System.Drawing.Size(95, 26);
            this.eTxt.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(232, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "e:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 629);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.eTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.encryptedTxt);
            this.Controls.Add(this.nTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decryptedTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pTxt);
            this.Controls.Add(this.encryptTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptTxt;
        private System.Windows.Forms.TextBox pTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decryptedTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nTxt;
        private System.Windows.Forms.TextBox encryptedTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eTxt;
        private System.Windows.Forms.Label label7;
    }
}

