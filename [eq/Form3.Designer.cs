
namespace _eq
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backtoacc = new System.Windows.Forms.Button();
            this.piazdabolbut = new System.Windows.Forms.Button();
            this.FTS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поздравляю, ты попал в WindowsForm gamedev разработчика cheba!  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Made by cheba по заказу - moonway";
            // 
            // backtoacc
            // 
            this.backtoacc.Location = new System.Drawing.Point(3, 177);
            this.backtoacc.Name = "backtoacc";
            this.backtoacc.Size = new System.Drawing.Size(128, 23);
            this.backtoacc.TabIndex = 3;
            this.backtoacc.Text = "Вернуться к акканту";
            this.backtoacc.UseVisualStyleBackColor = true;
            this.backtoacc.Click += new System.EventHandler(this.button1_Click);
            // 
            // piazdabolbut
            // 
            this.piazdabolbut.Location = new System.Drawing.Point(13, 62);
            this.piazdabolbut.Name = "piazdabolbut";
            this.piazdabolbut.Size = new System.Drawing.Size(75, 23);
            this.piazdabolbut.TabIndex = 4;
            this.piazdabolbut.Text = "Тут пизда";
            this.piazdabolbut.UseVisualStyleBackColor = true;
            this.piazdabolbut.Click += new System.EventHandler(this.button2_Click);
            // 
            // FTS
            // 
            this.FTS.Location = new System.Drawing.Point(280, 177);
            this.FTS.Name = "FTS";
            this.FTS.Size = new System.Drawing.Size(137, 23);
            this.FTS.TabIndex = 5;
            this.FTS.Text = "Future Science Softworks";
            this.FTS.UseVisualStyleBackColor = true;
            this.FTS.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 212);
            this.Controls.Add(this.FTS);
            this.Controls.Add(this.piazdabolbut);
            this.Controls.Add(this.backtoacc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backtoacc;
        private System.Windows.Forms.Button piazdabolbut;
        private System.Windows.Forms.Button FTS;
    }
}