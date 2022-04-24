namespace Sec3LabExam_Joplin
{
    partial class DecoderWheel
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
            this.cInput = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.rEncrypt = new System.Windows.Forms.RadioButton();
            this.rDecrypt = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cInput
            // 
            this.cInput.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cInput.Location = new System.Drawing.Point(16, 60);
            this.cInput.Multiline = true;
            this.cInput.Name = "cInput";
            this.cInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cInput.Size = new System.Drawing.Size(301, 483);
            this.cInput.TabIndex = 1;
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(490, 60);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(301, 483);
            this.txtMsg.TabIndex = 0;
            this.txtMsg.TabStop = false;
            // 
            // rEncrypt
            // 
            this.rEncrypt.AutoSize = true;
            this.rEncrypt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEncrypt.Location = new System.Drawing.Point(354, 100);
            this.rEncrypt.Name = "rEncrypt";
            this.rEncrypt.Size = new System.Drawing.Size(93, 26);
            this.rEncrypt.TabIndex = 0;
            this.rEncrypt.Text = "Encrypt";
            this.rEncrypt.UseVisualStyleBackColor = true;
            // 
            // rDecrypt
            // 
            this.rDecrypt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDecrypt.Location = new System.Drawing.Point(354, 169);
            this.rDecrypt.Name = "rDecrypt";
            this.rDecrypt.Size = new System.Drawing.Size(104, 24);
            this.rDecrypt.TabIndex = 0;
            this.rDecrypt.Text = "Decrypt";
            this.rDecrypt.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConvert.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(345, 260);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(124, 46);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Yellow;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(345, 377);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 46);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(345, 497);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIn.Location = new System.Drawing.Point(12, 33);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(218, 22);
            this.lblIn.TabIndex = 7;
            this.lblIn.Text = "Enter your message here!";
            // 
            // DecoderWheel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(803, 561);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.rDecrypt);
            this.Controls.Add(this.rEncrypt);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.cInput);
            this.Name = "DecoderWheel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDecoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cInput;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.RadioButton rEncrypt;
        private System.Windows.Forms.RadioButton rDecrypt;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblIn;
    }
}

