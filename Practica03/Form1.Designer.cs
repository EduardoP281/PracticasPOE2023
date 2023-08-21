namespace Practica03
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
            this.verificarButtom = new System.Windows.Forms.Button();
            this.numeroTxt = new System.Windows.Forms.TextBox();
            this.letraTxt = new System.Windows.Forms.TextBox();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // verificarButtom
            // 
            this.verificarButtom.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.verificarButtom.Location = new System.Drawing.Point(83, 163);
            this.verificarButtom.Name = "verificarButtom";
            this.verificarButtom.Size = new System.Drawing.Size(75, 23);
            this.verificarButtom.TabIndex = 0;
            this.verificarButtom.Text = "Verificar";
            this.verificarButtom.UseVisualStyleBackColor = true;
            this.verificarButtom.Click += new System.EventHandler(this.button1_Click);
            // 
            // numeroTxt
            // 
            this.numeroTxt.Location = new System.Drawing.Point(67, 55);
            this.numeroTxt.Name = "numeroTxt";
            this.numeroTxt.Size = new System.Drawing.Size(100, 23);
            this.numeroTxt.TabIndex = 1;
            // 
            // letraTxt
            // 
            this.letraTxt.Location = new System.Drawing.Point(67, 124);
            this.letraTxt.Name = "letraTxt";
            this.letraTxt.Size = new System.Drawing.Size(100, 23);
            this.letraTxt.TabIndex = 2;
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numeroLabel.Location = new System.Drawing.Point(12, 22);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(209, 30);
            this.numeroLabel.TabIndex = 3;
            this.numeroLabel.Text = "Insertar un numero";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textLabel.Location = new System.Drawing.Point(12, 91);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(219, 30);
            this.textLabel.TabIndex = 4;
            this.textLabel.Text = "Insertar una palabra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 224);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.numeroLabel);
            this.Controls.Add(this.letraTxt);
            this.Controls.Add(this.numeroTxt);
            this.Controls.Add(this.verificarButtom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button verificarButtom;
        private TextBox numeroTxt;
        private TextBox letraTxt;
        private Label numeroLabel;
        private Label textLabel;
    }
}