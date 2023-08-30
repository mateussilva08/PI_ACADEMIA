namespace PI_ACADEMIA
{
    partial class RedefinirSenha
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
            this.textBoxCONFIRMASENHA = new System.Windows.Forms.TextBox();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.buttonATUALIZAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCONFIRMASENHA
            // 
            this.textBoxCONFIRMASENHA.Location = new System.Drawing.Point(142, 366);
            this.textBoxCONFIRMASENHA.Name = "textBoxCONFIRMASENHA";
            this.textBoxCONFIRMASENHA.Size = new System.Drawing.Size(215, 20);
            this.textBoxCONFIRMASENHA.TabIndex = 0;
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Location = new System.Drawing.Point(142, 72);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.Size = new System.Drawing.Size(215, 20);
            this.textBoxSENHA.TabIndex = 1;
            this.textBoxSENHA.TextChanged += new System.EventHandler(this.textBoxSENHA_TextChanged);
            // 
            // buttonATUALIZAR
            // 
            this.buttonATUALIZAR.BackColor = System.Drawing.Color.Transparent;
            this.buttonATUALIZAR.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonATUALIZAR.Location = new System.Drawing.Point(201, 412);
            this.buttonATUALIZAR.Name = "buttonATUALIZAR";
            this.buttonATUALIZAR.Size = new System.Drawing.Size(104, 29);
            this.buttonATUALIZAR.TabIndex = 2;
            this.buttonATUALIZAR.Text = "Atualizar";
            this.buttonATUALIZAR.UseVisualStyleBackColor = false;
            this.buttonATUALIZAR.Click += new System.EventHandler(this.buttonATUALIZAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(160, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite a Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(160, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirme a Senha";
            // 
            // RedefinirSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::PI_ACADEMIA.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(544, 508);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonATUALIZAR);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textBoxCONFIRMASENHA);
            this.ForeColor = System.Drawing.Color.Green;
            this.Name = "RedefinirSenha";
            this.Text = "RedefinirSenha";
            this.Load += new System.EventHandler(this.RedefinirSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCONFIRMASENHA;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.Button buttonATUALIZAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}