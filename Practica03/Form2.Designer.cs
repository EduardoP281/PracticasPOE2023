namespace Practica03
{
    partial class Form2
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
            this.accionarBott = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accionarBott
            // 
            this.accionarBott.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.accionarBott.Location = new System.Drawing.Point(23, 25);
            this.accionarBott.Name = "accionarBott";
            this.accionarBott.Size = new System.Drawing.Size(301, 197);
            this.accionarBott.TabIndex = 0;
            this.accionarBott.Text = "Accionar";
            this.accionarBott.UseVisualStyleBackColor = true;
            this.accionarBott.Click += new System.EventHandler(this.accionarBott_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 245);
            this.Controls.Add(this.accionarBott);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttomCalcu;
        private Button button1;
        private Button button2;
        private Button accionarBott;
    }
}