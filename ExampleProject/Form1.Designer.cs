﻿namespace ExampleProject
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTest = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(144, 88);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(113, 25);
            this.lblTest.TabIndex = 0;
            this.lblTest.Text = "Test Label";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(378, 88);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(334, 31);
            this.txtTest.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(149, 200);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(276, 100);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Submit";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 672);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.lblTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnTest;
    }
}

