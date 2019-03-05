namespace KEYLOGGER_V1
{
    partial class FrmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNaoTraduzido = new System.Windows.Forms.TextBox();
            this.tmEnviarEmail = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtTraduzido = new System.Windows.Forms.TextBox();
            this.txtEditado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KEYLOGGER_V1.Properties.Resources.matrix1__42_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KEYLOGGER_V1.Properties.Resources.matrix1__42_;
            this.pictureBox2.Location = new System.Drawing.Point(340, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(378, 402);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txtNaoTraduzido
            // 
            this.txtNaoTraduzido.Location = new System.Drawing.Point(45, 14);
            this.txtNaoTraduzido.Multiline = true;
            this.txtNaoTraduzido.Name = "txtNaoTraduzido";
            this.txtNaoTraduzido.Size = new System.Drawing.Size(819, 111);
            this.txtNaoTraduzido.TabIndex = 2;
            this.txtNaoTraduzido.TabStop = false;
            this.txtNaoTraduzido.TextChanged += new System.EventHandler(this.txtTextoDigitado_TextChanged);
            // 
            // tmEnviarEmail
            // 
            this.tmEnviarEmail.Enabled = true;
            this.tmEnviarEmail.Interval = 300000;
            this.tmEnviarEmail.Tick += new System.EventHandler(this.tmEnviarEmail_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KEYLOGGER_V1.Properties.Resources.matrix1__42_;
            this.pictureBox3.Location = new System.Drawing.Point(-44, 398);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(378, 402);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::KEYLOGGER_V1.Properties.Resources.matrix1__42_;
            this.pictureBox4.Location = new System.Drawing.Point(340, 398);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(378, 402);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // txtTraduzido
            // 
            this.txtTraduzido.Location = new System.Drawing.Point(45, 181);
            this.txtTraduzido.Multiline = true;
            this.txtTraduzido.Name = "txtTraduzido";
            this.txtTraduzido.Size = new System.Drawing.Size(819, 105);
            this.txtTraduzido.TabIndex = 5;
            this.txtTraduzido.TabStop = false;
            // 
            // txtEditado
            // 
            this.txtEditado.Location = new System.Drawing.Point(45, 337);
            this.txtEditado.Multiline = true;
            this.txtEditado.Name = "txtEditado";
            this.txtEditado.Size = new System.Drawing.Size(819, 105);
            this.txtEditado.TabIndex = 6;
            this.txtEditado.TabStop = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(890, 577);
            this.Controls.Add(this.txtEditado);
            this.Controls.Add(this.txtTraduzido);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtNaoTraduzido);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KEY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmHome_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNaoTraduzido;
        private System.Windows.Forms.Timer tmEnviarEmail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtTraduzido;
        private System.Windows.Forms.TextBox txtEditado;
    }
}

