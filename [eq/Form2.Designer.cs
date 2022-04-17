
namespace _eq
{
    partial class Form2
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
            this.вашакк = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showpass = new System.Windows.Forms.Button();
            this.leftacc = new System.Windows.Forms.Button();
            this.who = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // вашакк
            // 
            this.вашакк.AutoSize = true;
            this.вашакк.Location = new System.Drawing.Point(103, 9);
            this.вашакк.Name = "вашакк";
            this.вашакк.Size = new System.Drawing.Size(71, 13);
            this.вашакк.TabIndex = 0;
            this.вашакк.Text = "Ваш аккаунт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "cheba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Belarus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "14:37";
            // 
            // showpass
            // 
            this.showpass.Location = new System.Drawing.Point(16, 91);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(137, 23);
            this.showpass.TabIndex = 4;
            this.showpass.Text = "Показать ваш пароль";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.Click += new System.EventHandler(this.button1_Click);
            // 
            // leftacc
            // 
            this.leftacc.Location = new System.Drawing.Point(204, 193);
            this.leftacc.Name = "leftacc";
            this.leftacc.Size = new System.Drawing.Size(106, 23);
            this.leftacc.TabIndex = 5;
            this.leftacc.Text = "Выйти с аккаунта";
            this.leftacc.UseVisualStyleBackColor = true;
            this.leftacc.Click += new System.EventHandler(this.button2_Click);
            // 
            // who
            // 
            this.who.Location = new System.Drawing.Point(16, 193);
            this.who.Name = "who";
            this.who.Size = new System.Drawing.Size(75, 23);
            this.who.TabIndex = 6;
            this.who.Text = "Где я?";
            this.who.UseVisualStyleBackColor = true;
            this.who.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 228);
            this.Controls.Add(this.who);
            this.Controls.Add(this.leftacc);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.вашакк);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label вашакк;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showpass;
        private System.Windows.Forms.Button leftacc;
        private System.Windows.Forms.Button who;
    }
}