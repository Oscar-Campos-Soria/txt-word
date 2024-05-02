
namespace txt_word
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnabrirWord = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnabrirWord
            // 
            this.btnabrirWord.Location = new System.Drawing.Point(15, 16);
            this.btnabrirWord.Name = "btnabrirWord";
            this.btnabrirWord.Size = new System.Drawing.Size(149, 58);
            this.btnabrirWord.TabIndex = 0;
            this.btnabrirWord.Text = "button1";
            this.btnabrirWord.UseVisualStyleBackColor = true;
            this.btnabrirWord.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(12, 91);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(406, 175);
            this.txtTexto.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnabrirWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnabrirWord;
        private System.Windows.Forms.TextBox txtTexto;
    }
}

