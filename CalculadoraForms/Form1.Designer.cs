namespace CalculadoraForms
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
            this.btn_somar = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_subtrair = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valor1 = new System.Windows.Forms.TextBox();
            this.txt_valor2 = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_somar
            // 
            this.btn_somar.Location = new System.Drawing.Point(607, 93);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(92, 23);
            this.btn_somar.TabIndex = 0;
            this.btn_somar.Text = "SOMAR";
            this.btn_somar.UseVisualStyleBackColor = true;
            this.btn_somar.Click += new System.EventHandler(this.btn_somar_Click);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Location = new System.Drawing.Point(607, 153);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(92, 23);
            this.btn_dividir.TabIndex = 1;
            this.btn_dividir.Text = "DIVIDIR";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btn_subtrair
            // 
            this.btn_subtrair.Location = new System.Drawing.Point(607, 209);
            this.btn_subtrair.Name = "btn_subtrair";
            this.btn_subtrair.Size = new System.Drawing.Size(92, 23);
            this.btn_subtrair.TabIndex = 2;
            this.btn_subtrair.Text = "SUBTRAIR";
            this.btn_subtrair.UseVisualStyleBackColor = true;
            this.btn_subtrair.Click += new System.EventHandler(this.btn_subtrair_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Location = new System.Drawing.Point(607, 266);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(92, 23);
            this.btn_multiplicar.TabIndex = 3;
            this.btn_multiplicar.Text = "MULTIPLICAR";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor2";
            // 
            // txt_valor1
            // 
            this.txt_valor1.Location = new System.Drawing.Point(230, 126);
            this.txt_valor1.Name = "txt_valor1";
            this.txt_valor1.Size = new System.Drawing.Size(100, 23);
            this.txt_valor1.TabIndex = 6;
            this.txt_valor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_valor2
            // 
            this.txt_valor2.Location = new System.Drawing.Point(230, 219);
            this.txt_valor2.Name = "txt_valor2";
            this.txt_valor2.Size = new System.Drawing.Size(100, 23);
            this.txt_valor2.TabIndex = 7;
            this.txt_valor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(440, 177);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(100, 23);
            this.txt_resultado.TabIndex = 8;
            this.txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(369, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_valor2);
            this.Controls.Add(this.txt_valor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_subtrair);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_somar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_somar;
        private Button btn_dividir;
        private Button btn_subtrair;
        private Button btn_multiplicar;
        private Label label1;
        private Label label2;
        private TextBox txt_valor1;
        private TextBox txt_valor2;
        private TextBox txt_resultado;
        private Label label3;
    }
}