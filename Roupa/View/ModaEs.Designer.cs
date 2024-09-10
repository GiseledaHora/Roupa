namespace Roupa.View
{
    partial class Moda
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbx_tamanho = new ComboBox();
            cbx_cor = new ComboBox();
            cbx_numero = new ComboBox();
            cbx_modelo = new ComboBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 70);
            label1.Name = "label1";
            label1.Size = new Size(289, 30);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Moda Esportiva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 150);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Tamanho:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 196);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Modelo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 239);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 3;
            label4.Text = "Cor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 279);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Número:";
            // 
            // cbx_tamanho
            // 
            cbx_tamanho.FormattingEnabled = true;
            cbx_tamanho.Items.AddRange(new object[] { "P", "PP", "M", "G", "GG" });
            cbx_tamanho.Location = new Point(220, 147);
            cbx_tamanho.Name = "cbx_tamanho";
            cbx_tamanho.Size = new Size(121, 23);
            cbx_tamanho.TabIndex = 5;
            // 
            // cbx_cor
            // 
            cbx_cor.FormattingEnabled = true;
            cbx_cor.Items.AddRange(new object[] { "Braco com verde", "verde escuro com vermelho" });
            cbx_cor.Location = new Point(220, 236);
            cbx_cor.Name = "cbx_cor";
            cbx_cor.Size = new Size(121, 23);
            cbx_cor.TabIndex = 6;
            // 
            // cbx_numero
            // 
            cbx_numero.FormattingEnabled = true;
            cbx_numero.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbx_numero.Location = new Point(220, 276);
            cbx_numero.Name = "cbx_numero";
            cbx_numero.Size = new Size(121, 23);
            cbx_numero.TabIndex = 7;
            // 
            // cbx_modelo
            // 
            cbx_modelo.FormattingEnabled = true;
            cbx_modelo.Items.AddRange(new object[] { "Jaqueta", "Corta vento", "Gola V" });
            cbx_modelo.Location = new Point(220, 193);
            cbx_modelo.Name = "cbx_modelo";
            cbx_modelo.Size = new Size(121, 23);
            cbx_modelo.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 335);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 10;
            label6.Text = "Finalizar a Compra:";
            // 
            // button1
            // 
            button1.Location = new Point(199, 328);
            button1.Name = "button1";
            button1.Size = new Size(161, 28);
            button1.TabIndex = 11;
            button1.Text = "SIM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Moda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 388);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(cbx_modelo);
            Controls.Add(cbx_numero);
            Controls.Add(cbx_cor);
            Controls.Add(cbx_tamanho);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Moda";
            Text = "Moda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbx_tamanho;
        private ComboBox cbx_cor;
        private ComboBox cbx_numero;
        private ComboBox cbx_modelo;
        private Label label6;
        private Button button1;
    }
}