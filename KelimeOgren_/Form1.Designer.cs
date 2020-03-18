namespace KelimeOgren_
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTürkçe = new System.Windows.Forms.TextBox();
            this.Txting = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblSüre = new System.Windows.Forms.Label();
            this.LblKelime = new System.Windows.Forms.Label();
            this.LblYanit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // TxtTürkçe
            // 
            this.TxtTürkçe.Location = new System.Drawing.Point(137, 81);
            this.TxtTürkçe.Name = "TxtTürkçe";
            this.TxtTürkçe.Size = new System.Drawing.Size(291, 30);
            this.TxtTürkçe.TabIndex = 1;
            this.TxtTürkçe.TextChanged += new System.EventHandler(this.TxtTürkçe_TextChanged);
            // 
            // Txting
            // 
            this.Txting.Enabled = false;
            this.Txting.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txting.Location = new System.Drawing.Point(137, 33);
            this.Txting.Name = "Txting";
            this.Txting.Size = new System.Drawing.Size(291, 30);
            this.Txting.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türkçe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kelime:";
            // 
            // LblSüre
            // 
            this.LblSüre.AutoSize = true;
            this.LblSüre.Location = new System.Drawing.Point(669, 33);
            this.LblSüre.Name = "LblSüre";
            this.LblSüre.Size = new System.Drawing.Size(33, 24);
            this.LblSüre.TabIndex = 6;
            this.LblSüre.Text = "90";
            // 
            // LblKelime
            // 
            this.LblKelime.AutoSize = true;
            this.LblKelime.Location = new System.Drawing.Point(680, 69);
            this.LblKelime.Name = "LblKelime";
            this.LblKelime.Size = new System.Drawing.Size(22, 24);
            this.LblKelime.TabIndex = 7;
            this.LblKelime.Text = "0";
            // 
            // LblYanit
            // 
            this.LblYanit.AutoSize = true;
            this.LblYanit.Location = new System.Drawing.Point(490, 119);
            this.LblYanit.Name = "LblYanit";
            this.LblYanit.Size = new System.Drawing.Size(64, 24);
            this.LblYanit.TabIndex = 8;
            this.LblYanit.Text = "label5";
            this.LblYanit.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(765, 142);
            this.Controls.Add(this.LblYanit);
            this.Controls.Add(this.LblKelime);
            this.Controls.Add(this.LblSüre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTürkçe);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Öğren";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTürkçe;
        private System.Windows.Forms.TextBox Txting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblSüre;
        private System.Windows.Forms.Label LblKelime;
        private System.Windows.Forms.Label LblYanit;
        private System.Windows.Forms.Timer timer1;
    }
}

