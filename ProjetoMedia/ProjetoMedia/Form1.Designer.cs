namespace ProjetoMedia
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
            this.btnMedia = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lbln1 = new System.Windows.Forms.Label();
            this.lbln2 = new System.Windows.Forms.Label();
            this.lbln3 = new System.Windows.Forms.Label();
            this.lbln4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.lblAprovados = new System.Windows.Forms.Label();
            this.lblReprovados = new System.Windows.Forms.Label();
            this.listAprovados = new System.Windows.Forms.ListBox();
            this.listReprovados = new System.Windows.Forms.ListBox();
            this.lblTotalAprovados = new System.Windows.Forms.Label();
            this.lblTotalReprovados = new System.Windows.Forms.Label();
            this.totalAprovados = new System.Windows.Forms.Label();
            this.totalReprovados = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(11, 201);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(107, 38);
            this.btnMedia.TabIndex = 0;
            this.btnMedia.Text = "Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lbln1
            // 
            this.lbln1.AutoSize = true;
            this.lbln1.Location = new System.Drawing.Point(8, 80);
            this.lbln1.Name = "lbln1";
            this.lbln1.Size = new System.Drawing.Size(42, 13);
            this.lbln1.TabIndex = 2;
            this.lbln1.Text = "Nota 1:";
            // 
            // lbln2
            // 
            this.lbln2.AutoSize = true;
            this.lbln2.Location = new System.Drawing.Point(8, 106);
            this.lbln2.Name = "lbln2";
            this.lbln2.Size = new System.Drawing.Size(42, 13);
            this.lbln2.TabIndex = 3;
            this.lbln2.Text = "Nota 2:";
            // 
            // lbln3
            // 
            this.lbln3.AutoSize = true;
            this.lbln3.Location = new System.Drawing.Point(8, 132);
            this.lbln3.Name = "lbln3";
            this.lbln3.Size = new System.Drawing.Size(42, 13);
            this.lbln3.TabIndex = 4;
            this.lbln3.Text = "Nota 3:";
            // 
            // lbln4
            // 
            this.lbln4.AutoSize = true;
            this.lbln4.Location = new System.Drawing.Point(8, 158);
            this.lbln4.Name = "lbln4";
            this.lbln4.Size = new System.Drawing.Size(42, 13);
            this.lbln4.TabIndex = 5;
            this.lbln4.Text = "Nota 4:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(52, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(85, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(52, 73);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(58, 20);
            this.txtN1.TabIndex = 7;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(52, 99);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(58, 20);
            this.txtN2.TabIndex = 8;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(52, 125);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(58, 20);
            this.txtN3.TabIndex = 9;
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(52, 151);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(58, 20);
            this.txtN4.TabIndex = 10;
            // 
            // lblAprovados
            // 
            this.lblAprovados.AutoSize = true;
            this.lblAprovados.Location = new System.Drawing.Point(325, 47);
            this.lblAprovados.Name = "lblAprovados";
            this.lblAprovados.Size = new System.Drawing.Size(58, 13);
            this.lblAprovados.TabIndex = 11;
            this.lblAprovados.Text = "Aprovados";
            // 
            // lblReprovados
            // 
            this.lblReprovados.AutoSize = true;
            this.lblReprovados.Location = new System.Drawing.Point(548, 47);
            this.lblReprovados.Name = "lblReprovados";
            this.lblReprovados.Size = new System.Drawing.Size(65, 13);
            this.lblReprovados.TabIndex = 12;
            this.lblReprovados.Text = "Reprovados";
            // 
            // listAprovados
            // 
            this.listAprovados.FormattingEnabled = true;
            this.listAprovados.Location = new System.Drawing.Point(312, 63);
            this.listAprovados.Name = "listAprovados";
            this.listAprovados.Size = new System.Drawing.Size(192, 355);
            this.listAprovados.TabIndex = 15;
            // 
            // listReprovados
            // 
            this.listReprovados.FormattingEnabled = true;
            this.listReprovados.Location = new System.Drawing.Point(536, 63);
            this.listReprovados.Name = "listReprovados";
            this.listReprovados.Size = new System.Drawing.Size(211, 355);
            this.listReprovados.TabIndex = 16;
            // 
            // lblTotalAprovados
            // 
            this.lblTotalAprovados.AutoSize = true;
            this.lblTotalAprovados.Location = new System.Drawing.Point(161, 47);
            this.lblTotalAprovados.Name = "lblTotalAprovados";
            this.lblTotalAprovados.Size = new System.Drawing.Size(99, 13);
            this.lblTotalAprovados.TabIndex = 17;
            this.lblTotalAprovados.Text = "Total de aprovados";
            // 
            // lblTotalReprovados
            // 
            this.lblTotalReprovados.AutoSize = true;
            this.lblTotalReprovados.Location = new System.Drawing.Point(161, 106);
            this.lblTotalReprovados.Name = "lblTotalReprovados";
            this.lblTotalReprovados.Size = new System.Drawing.Size(102, 13);
            this.lblTotalReprovados.TabIndex = 18;
            this.lblTotalReprovados.Text = "Total de reprovados";
            // 
            // totalAprovados
            // 
            this.totalAprovados.AutoSize = true;
            this.totalAprovados.Location = new System.Drawing.Point(177, 73);
            this.totalAprovados.Name = "totalAprovados";
            this.totalAprovados.Size = new System.Drawing.Size(0, 13);
            this.totalAprovados.TabIndex = 19;
            // 
            // totalReprovados
            // 
            this.totalReprovados.AutoSize = true;
            this.totalReprovados.Location = new System.Drawing.Point(177, 132);
            this.totalReprovados.Name = "totalReprovados";
            this.totalReprovados.Size = new System.Drawing.Size(0, 13);
            this.totalReprovados.TabIndex = 20;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(124, 201);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 38);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(200, 239);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.totalReprovados);
            this.Controls.Add(this.totalAprovados);
            this.Controls.Add(this.lblTotalReprovados);
            this.Controls.Add(this.lblTotalAprovados);
            this.Controls.Add(this.listReprovados);
            this.Controls.Add(this.listAprovados);
            this.Controls.Add(this.lblReprovados);
            this.Controls.Add(this.lblAprovados);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbln4);
            this.Controls.Add(this.lbln3);
            this.Controls.Add(this.lbln2);
            this.Controls.Add(this.lbln1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnMedia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lbln1;
        private System.Windows.Forms.Label lbln2;
        private System.Windows.Forms.Label lbln3;
        private System.Windows.Forms.Label lbln4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.Label lblAprovados;
        private System.Windows.Forms.Label lblReprovados;
        private System.Windows.Forms.ListBox listAprovados;
        private System.Windows.Forms.ListBox listReprovados;
        private System.Windows.Forms.Label lblTotalAprovados;
        private System.Windows.Forms.Label lblTotalReprovados;
        private System.Windows.Forms.Label totalAprovados;
        private System.Windows.Forms.Label totalReprovados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblError;
    }
}

