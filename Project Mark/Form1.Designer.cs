namespace Project_Mark
{
    partial class Laucher
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox Login;
            System.Windows.Forms.Button button3;
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Jogar = new System.Windows.Forms.PictureBox();
            this.Capa = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.servidores = new System.Windows.Forms.PictureBox();
            Login = new System.Windows.Forms.PictureBox();
            button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jogar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Capa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servidores)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sign up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 400);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 20);
            this.textBox2.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 434);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Lembrar senha";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Esqueci senha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_Mark.Properties.Resources.kkaka;
            this.pictureBox2.Location = new System.Drawing.Point(469, 436);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 42);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Mark.Properties.Resources.twittuter;
            this.pictureBox1.Location = new System.Drawing.Point(418, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            Login.Image = global::Project_Mark.Properties.Resources.faceb;
            Login.Location = new System.Drawing.Point(358, 435);
            Login.Name = "Login";
            Login.Size = new System.Drawing.Size(38, 38);
            Login.TabIndex = 13;
            Login.TabStop = false;
            // 
            // Jogar
            // 
            this.Jogar.Image = global::Project_Mark.Properties.Resources.jugar;
            this.Jogar.Location = new System.Drawing.Point(366, 347);
            this.Jogar.Name = "Jogar";
            this.Jogar.Size = new System.Drawing.Size(143, 39);
            this.Jogar.TabIndex = 12;
            this.Jogar.TabStop = false;
            // 
            // Capa
            // 
            this.Capa.Image = global::Project_Mark.Properties.Resources.timthumb;
            this.Capa.Location = new System.Drawing.Point(-2, 0);
            this.Capa.Name = "Capa";
            this.Capa.Size = new System.Drawing.Size(541, 274);
            this.Capa.TabIndex = 11;
            this.Capa.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.BackgroundImage = global::Project_Mark.Properties.Resources.fundo;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(12, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Senha";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.DarkGoldenrod;
            button3.BackgroundImage = global::Project_Mark.Properties.Resources.fundo;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.ForeColor = System.Drawing.Color.Yellow;
            button3.Location = new System.Drawing.Point(12, 361);
            button3.Name = "button3";
            button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            button3.Size = new System.Drawing.Size(116, 28);
            button3.TabIndex = 2;
            button3.TabStop = false;
            button3.Text = "E-mail";
            button3.UseCompatibleTextRendering = true;
            button3.UseMnemonic = false;
            button3.UseVisualStyleBackColor = false;
            // 
            // servidores
            // 
            this.servidores.Image = global::Project_Mark.Properties.Resources.SERVER;
            this.servidores.Location = new System.Drawing.Point(534, 0);
            this.servidores.Name = "servidores";
            this.servidores.Size = new System.Drawing.Size(264, 478);
            this.servidores.TabIndex = 16;
            this.servidores.TabStop = false;
            // 
            // Laucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.servidores);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(Login);
            this.Controls.Add(this.Jogar);
            this.Controls.Add(this.Capa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(button3);
            this.Controls.Add(this.button2);
            this.Name = "Laucher";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Laucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jogar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Capa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servidores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Capa;
        private System.Windows.Forms.PictureBox Jogar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox servidores;
    }
}

