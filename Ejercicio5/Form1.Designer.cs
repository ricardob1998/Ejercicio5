
namespace Ejercicio5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FilatextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NumerosAletorioslistBox = new System.Windows.Forms.ListBox();
            this.ColumnatextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño de la Fila";
            // 
            // FilatextBox
            // 
            this.FilatextBox.Location = new System.Drawing.Point(108, 25);
            this.FilatextBox.Name = "FilatextBox";
            this.FilatextBox.Size = new System.Drawing.Size(125, 20);
            this.FilatextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumerosAletorioslistBox
            // 
            this.NumerosAletorioslistBox.FormattingEnabled = true;
            this.NumerosAletorioslistBox.Location = new System.Drawing.Point(35, 156);
            this.NumerosAletorioslistBox.Name = "NumerosAletorioslistBox";
            this.NumerosAletorioslistBox.Size = new System.Drawing.Size(229, 173);
            this.NumerosAletorioslistBox.TabIndex = 3;
            // 
            // ColumnatextBox
            // 
            this.ColumnatextBox.Location = new System.Drawing.Point(108, 74);
            this.ColumnatextBox.Name = "ColumnatextBox";
            this.ColumnatextBox.Size = new System.Drawing.Size(125, 20);
            this.ColumnatextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tamaño de la Columna";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 341);
            this.Controls.Add(this.ColumnatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumerosAletorioslistBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilatextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilatextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox NumerosAletorioslistBox;
        private System.Windows.Forms.TextBox ColumnatextBox;
        private System.Windows.Forms.Label label2;
    }
}

