namespace iniciar
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
            btn_Procesar = new Button();
            btn_Limpiar = new Button();
            btn_Salir = new Button();
            txt_edad = new TextBox();
            txt_genero = new TextBox();
            txt_Situacion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_Procesar
            // 
            btn_Procesar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Procesar.Location = new Point(117, 379);
            btn_Procesar.Name = "btn_Procesar";
            btn_Procesar.Size = new Size(115, 59);
            btn_Procesar.TabIndex = 0;
            btn_Procesar.Text = "Procear";
            btn_Procesar.UseVisualStyleBackColor = true;
            btn_Procesar.Click += btn_Procesar_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Limpiar.Location = new Point(303, 379);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(115, 59);
            btn_Limpiar.TabIndex = 1;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Salir.Location = new Point(472, 379);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(128, 59);
            btn_Salir.TabIndex = 2;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // txt_edad
            // 
            txt_edad.Location = new Point(293, 26);
            txt_edad.Name = "txt_edad";
            txt_edad.Size = new Size(125, 27);
            txt_edad.TabIndex = 3;
            // 
            // txt_genero
            // 
            txt_genero.Location = new Point(293, 144);
            txt_genero.Name = "txt_genero";
            txt_genero.Size = new Size(125, 27);
            txt_genero.TabIndex = 4;
            // 
            // txt_Situacion
            // 
            txt_Situacion.Location = new Point(293, 267);
            txt_Situacion.Name = "txt_Situacion";
            txt_Situacion.Size = new Size(212, 27);
            txt_Situacion.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(117, 26);
            label1.Name = "label1";
            label1.Size = new Size(66, 31);
            label1.TabIndex = 6;
            label1.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(117, 144);
            label2.Name = "label2";
            label2.Size = new Size(91, 31);
            label2.TabIndex = 7;
            label2.Text = "Genero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(117, 267);
            label3.Name = "label3";
            label3.Size = new Size(115, 31);
            label3.TabIndex = 8;
            label3.Text = "Situacion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Situacion);
            Controls.Add(txt_genero);
            Controls.Add(txt_edad);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Procesar);
            Name = "Form1";
            Text = "Genero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Procesar;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private TextBox txt_edad;
        private TextBox txt_genero;
        private TextBox txt_Situacion;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
