namespace WindowsFormsApp1
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtb_nome = new System.Windows.Forms.TextBox();
            this.txtb_email = new System.Windows.Forms.TextBox();
            this.txtb_idade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(66, 33);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            this.lbl_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(352, 33);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(621, 33);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(34, 13);
            this.lbl_idade.TabIndex = 2;
            this.lbl_idade.Text = "Idade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(655, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(655, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(655, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtb_nome
            // 
            this.txtb_nome.Location = new System.Drawing.Point(69, 49);
            this.txtb_nome.Name = "txtb_nome";
            this.txtb_nome.Size = new System.Drawing.Size(100, 20);
            this.txtb_nome.TabIndex = 6;
            // 
            // txtb_email
            // 
            this.txtb_email.Location = new System.Drawing.Point(355, 49);
            this.txtb_email.Name = "txtb_email";
            this.txtb_email.Size = new System.Drawing.Size(100, 20);
            this.txtb_email.TabIndex = 7;
            // 
            // txtb_idade
            // 
            this.txtb_idade.Location = new System.Drawing.Point(624, 49);
            this.txtb_idade.Name = "txtb_idade";
            this.txtb_idade.Size = new System.Drawing.Size(100, 20);
            this.txtb_idade.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtb_idade);
            this.Controls.Add(this.txtb_email);
            this.Controls.Add(this.txtb_nome);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtb_nome;
        private System.Windows.Forms.TextBox txtb_email;
        private System.Windows.Forms.TextBox txtb_idade;
    }
}

