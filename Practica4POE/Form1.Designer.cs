namespace Practica4POE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.horaInicioComboBox = new System.Windows.Forms.ComboBox();
            this.horaFinComboBox = new System.Windows.Forms.ComboBox();
            this.ampmComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreMateriaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guardarButton = new System.Windows.Forms.Button();
            this.listaHorario = new System.Windows.Forms.ListBox();
            this.horarioGropuBox = new System.Windows.Forms.GroupBox();
            this.horarioGropuBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // horaInicioComboBox
            // 
            this.horaInicioComboBox.FormattingEnabled = true;
            this.horaInicioComboBox.Location = new System.Drawing.Point(219, 56);
            this.horaInicioComboBox.Name = "horaInicioComboBox";
            this.horaInicioComboBox.Size = new System.Drawing.Size(146, 23);
            this.horaInicioComboBox.TabIndex = 0;
            // 
            // horaFinComboBox
            // 
            this.horaFinComboBox.FormattingEnabled = true;
            this.horaFinComboBox.Location = new System.Drawing.Point(32, 144);
            this.horaFinComboBox.Name = "horaFinComboBox";
            this.horaFinComboBox.Size = new System.Drawing.Size(158, 23);
            this.horaFinComboBox.TabIndex = 1;
            // 
            // ampmComboBox
            // 
            this.ampmComboBox.FormattingEnabled = true;
            this.ampmComboBox.Location = new System.Drawing.Point(219, 144);
            this.ampmComboBox.Name = "ampmComboBox";
            this.ampmComboBox.Size = new System.Drawing.Size(146, 23);
            this.ampmComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de la materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(219, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora de fin";
            // 
            // nombreMateriaTextBox
            // 
            this.nombreMateriaTextBox.Location = new System.Drawing.Point(32, 56);
            this.nombreMateriaTextBox.Name = "nombreMateriaTextBox";
            this.nombreMateriaTextBox.Size = new System.Drawing.Size(158, 23);
            this.nombreMateriaTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(219, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "A.M./P.M.";
            // 
            // guardarButton
            // 
            this.guardarButton.BackColor = System.Drawing.Color.LightBlue;
            this.guardarButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guardarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guardarButton.Location = new System.Drawing.Point(42, 185);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(90, 26);
            this.guardarButton.TabIndex = 8;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = false;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // listaHorario
            // 
            this.listaHorario.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listaHorario.FormattingEnabled = true;
            this.listaHorario.ItemHeight = 17;
            this.listaHorario.Location = new System.Drawing.Point(69, 247);
            this.listaHorario.Name = "listaHorario";
            this.listaHorario.Size = new System.Drawing.Size(308, 123);
            this.listaHorario.TabIndex = 9;
            // 
            // horarioGropuBox
            // 
            this.horarioGropuBox.BackColor = System.Drawing.Color.MistyRose;
            this.horarioGropuBox.Controls.Add(this.ampmComboBox);
            this.horarioGropuBox.Controls.Add(this.horaInicioComboBox);
            this.horarioGropuBox.Controls.Add(this.guardarButton);
            this.horarioGropuBox.Controls.Add(this.horaFinComboBox);
            this.horarioGropuBox.Controls.Add(this.label4);
            this.horarioGropuBox.Controls.Add(this.label1);
            this.horarioGropuBox.Controls.Add(this.nombreMateriaTextBox);
            this.horarioGropuBox.Controls.Add(this.label2);
            this.horarioGropuBox.Controls.Add(this.label3);
            this.horarioGropuBox.Location = new System.Drawing.Point(12, 12);
            this.horarioGropuBox.Name = "horarioGropuBox";
            this.horarioGropuBox.Size = new System.Drawing.Size(419, 229);
            this.horarioGropuBox.TabIndex = 10;
            this.horarioGropuBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.horarioGropuBox);
            this.Controls.Add(this.listaHorario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.horarioGropuBox.ResumeLayout(false);
            this.horarioGropuBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox horaInicioComboBox;
        private ComboBox horaFinComboBox;
        private ComboBox ampmComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nombreMateriaTextBox;
        private Label label4;
        private Button guardarButton;
        private ListBox listaHorario;
        private GroupBox horarioGropuBox;
    }
}