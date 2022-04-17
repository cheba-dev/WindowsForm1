
namespace _eq
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.logtext = new System.Windows.Forms.Label();
            this.passtext = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.closebut = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 204);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // logtext
            // 
            this.logtext.AutoSize = true;
            this.logtext.Location = new System.Drawing.Point(40, 68);
            this.logtext.Name = "logtext";
            this.logtext.Size = new System.Drawing.Size(33, 13);
            this.logtext.TabIndex = 3;
            this.logtext.Text = "Login";
            // 
            // passtext
            // 
            this.passtext.AutoSize = true;
            this.passtext.Location = new System.Drawing.Point(22, 94);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(53, 13);
            this.passtext.TabIndex = 5;
            this.passtext.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(81, 91);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 4;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(204, 65);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(106, 46);
            this.Enter.TabIndex = 6;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // closebut
            // 
            this.closebut.Location = new System.Drawing.Point(245, 169);
            this.closebut.Name = "closebut";
            this.closebut.Size = new System.Drawing.Size(75, 23);
            this.closebut.TabIndex = 7;
            this.closebut.Text = "Закрыть";
            this.closebut.UseVisualStyleBackColor = true;
            this.closebut.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(81, 65);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 204);
            this.Controls.Add(this.login);
            this.Controls.Add(this.closebut);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.password);
            this.Controls.Add(this.logtext);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label logtext;
        private System.Windows.Forms.Label passtext;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button closebut;
        private System.Windows.Forms.TextBox login;
    }
}

