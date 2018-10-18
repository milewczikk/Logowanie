namespace WindowsFormsApplication1
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
            this.nierobot = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.TextBox();
            this.weryfikuj = new System.Windows.Forms.Button();
            this.robot = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.log1 = new System.Windows.Forms.GroupBox();
            this.log2 = new System.Windows.Forms.GroupBox();
            this.wyslij = new System.Windows.Forms.Button();
            this.log3 = new System.Windows.Forms.GroupBox();
            this.sprawdz = new System.Windows.Forms.Button();
            this.sprawdzenie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.log1.SuspendLayout();
            this.log2.SuspendLayout();
            this.log3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nierobot
            // 
            this.nierobot.AutoSize = true;
            this.nierobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nierobot.Location = new System.Drawing.Point(96, 175);
            this.nierobot.Name = "nierobot";
            this.nierobot.Size = new System.Drawing.Size(55, 24);
            this.nierobot.TabIndex = 0;
            this.nierobot.Text = "NIE";
            this.nierobot.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasło:";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(74, 16);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(106, 20);
            this.login.TabIndex = 3;
            // 
            // haslo
            // 
            this.haslo.Location = new System.Drawing.Point(74, 63);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(106, 20);
            this.haslo.TabIndex = 4;
            this.haslo.UseSystemPasswordChar = true;
            // 
            // weryfikuj
            // 
            this.weryfikuj.Location = new System.Drawing.Point(251, 38);
            this.weryfikuj.Name = "weryfikuj";
            this.weryfikuj.Size = new System.Drawing.Size(127, 44);
            this.weryfikuj.TabIndex = 5;
            this.weryfikuj.Text = "Weryfikacja";
            this.weryfikuj.UseVisualStyleBackColor = true;
            this.weryfikuj.Click += new System.EventHandler(this.weryfikuj_Click);
            // 
            // robot
            // 
            this.robot.AutoSize = true;
            this.robot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.robot.Location = new System.Drawing.Point(16, 175);
            this.robot.Name = "robot";
            this.robot.Size = new System.Drawing.Size(58, 24);
            this.robot.TabIndex = 6;
            this.robot.Text = "TAK";
            this.robot.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Czy jesteś robotem?";
            // 
            // log1
            // 
            this.log1.Controls.Add(this.label3);
            this.log1.Controls.Add(this.robot);
            this.log1.Controls.Add(this.weryfikuj);
            this.log1.Controls.Add(this.haslo);
            this.log1.Controls.Add(this.login);
            this.log1.Controls.Add(this.label2);
            this.log1.Controls.Add(this.label1);
            this.log1.Controls.Add(this.nierobot);
            this.log1.Location = new System.Drawing.Point(13, 15);
            this.log1.Name = "log1";
            this.log1.Size = new System.Drawing.Size(436, 243);
            this.log1.TabIndex = 8;
            this.log1.TabStop = false;
            // 
            // log2
            // 
            this.log2.Controls.Add(this.wyslij);
            this.log2.Controls.Add(this.log3);
            this.log2.Controls.Add(this.email);
            this.log2.Controls.Add(this.label4);
            this.log2.Location = new System.Drawing.Point(12, 31);
            this.log2.Name = "log2";
            this.log2.Size = new System.Drawing.Size(524, 365);
            this.log2.TabIndex = 9;
            this.log2.TabStop = false;
            // 
            // wyslij
            // 
            this.wyslij.Location = new System.Drawing.Point(356, 65);
            this.wyslij.Name = "wyslij";
            this.wyslij.Size = new System.Drawing.Size(107, 28);
            this.wyslij.TabIndex = 6;
            this.wyslij.Text = "Wyślij";
            this.wyslij.UseVisualStyleBackColor = true;
            this.wyslij.Click += new System.EventHandler(this.wyslij_Click);
            // 
            // log3
            // 
            this.log3.Controls.Add(this.sprawdz);
            this.log3.Controls.Add(this.sprawdzenie);
            this.log3.Controls.Add(this.label5);
            this.log3.Location = new System.Drawing.Point(9, 117);
            this.log3.Name = "log3";
            this.log3.Size = new System.Drawing.Size(438, 128);
            this.log3.TabIndex = 5;
            this.log3.TabStop = false;
            // 
            // sprawdz
            // 
            this.sprawdz.Location = new System.Drawing.Point(243, 63);
            this.sprawdz.Name = "sprawdz";
            this.sprawdz.Size = new System.Drawing.Size(107, 28);
            this.sprawdz.TabIndex = 7;
            this.sprawdz.Text = "Sprawdz";
            this.sprawdz.UseVisualStyleBackColor = true;
            this.sprawdz.Click += new System.EventHandler(this.sprawdz_Click);
            // 
            // sprawdzenie
            // 
            this.sprawdzenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sprawdzenie.Location = new System.Drawing.Point(37, 63);
            this.sprawdzenie.Name = "sprawdzenie";
            this.sprawdzenie.Size = new System.Drawing.Size(160, 26);
            this.sprawdzenie.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(25, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Wprowadz kod:";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.email.Location = new System.Drawing.Point(46, 68);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(258, 26);
            this.email.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(442, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Wprowadz e-mail na który zostanie wysłany kod weryfikacyjny:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 457);
            this.Controls.Add(this.log2);
            this.Controls.Add(this.log1);
            this.Name = "Form1";
            this.Text = "Logowanie";
            this.log1.ResumeLayout(false);
            this.log1.PerformLayout();
            this.log2.ResumeLayout(false);
            this.log2.PerformLayout();
            this.log3.ResumeLayout(false);
            this.log3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox nierobot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox haslo;
        private System.Windows.Forms.Button weryfikuj;
        private System.Windows.Forms.CheckBox robot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox log1;
        private System.Windows.Forms.GroupBox log2;
        private System.Windows.Forms.GroupBox log3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button wyslij;
        private System.Windows.Forms.Button sprawdz;
        private System.Windows.Forms.TextBox sprawdzenie;
        private System.Windows.Forms.Label label5;
    }
}

