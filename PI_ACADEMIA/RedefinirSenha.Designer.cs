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
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCONFIRMASENHA
            // 
            this.textBoxCONFIRMASENHA.Location = new System.Drawing.Point(210, 276);
            this.textBoxCONFIRMASENHA.Name = "textBoxCONFIRMASENHA";
            this.textBoxCONFIRMASENHA.Size = new System.Drawing.Size(215, 20);
            this.textBoxCONFIRMASENHA.TabIndex = 0;
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Location = new System.Drawing.Point(210, 213);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.Size = new System.Drawing.Size(215, 20);
            this.textBoxSENHA.TabIndex = 1;
            // 
            // buttonATUALIZAR
            // 
            this.buttonATUALIZAR.Location = new System.Drawing.Point(280, 328);
            this.buttonATUALIZAR.Name = "buttonATUALIZAR";
            this.buttonATUALIZAR.Size = new System.Drawing.Size(75, 23);
            this.buttonATUALIZAR.TabIndex = 2;
            this.buttonATUALIZAR.Text = "Atualizar";
            this.buttonATUALIZAR.UseVisualStyleBackColor = true;
            this.buttonATUALIZAR.Click += new System.EventHandler(this.buttonATUALIZAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(207, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite a Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(207, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirme a Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(243, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "FitHub";
            // 
            // RedefinirSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(667, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonATUALIZAR);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textBoxCONFIRMASENHA);
            this.Name = "RedefinirSenha";
            this.Text = "RedefinirSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCONFIRMASENHA;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.Button buttonATUALIZAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}