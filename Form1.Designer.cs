namespace Ejercicio3
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
            this.LB_ENUNCIADO = new System.Windows.Forms.Label();
            this.BTN_INGRESAR = new System.Windows.Forms.Button();
            this.TX_1 = new System.Windows.Forms.TextBox();
            this.TX_RESULTADO = new System.Windows.Forms.TextBox();
            this.BTN_MOSTRAR = new System.Windows.Forms.Button();
            this.LB_RESULTADO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_ENUNCIADO
            // 
            this.LB_ENUNCIADO.Location = new System.Drawing.Point(12, 9);
            this.LB_ENUNCIADO.Name = "LB_ENUNCIADO";
            this.LB_ENUNCIADO.Size = new System.Drawing.Size(655, 36);
            this.LB_ENUNCIADO.TabIndex = 0;
            this.LB_ENUNCIADO.Text = "Desarrollar un programa que permita cargar una cantidad n de números ingresados p" +
    "or el usuario y mostrar los números ingresados en un textbox y el resultado en u" +
    "n label";
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.Location = new System.Drawing.Point(176, 66);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_INGRESAR.TabIndex = 1;
            this.BTN_INGRESAR.Text = "Ingresar";
            this.BTN_INGRESAR.UseVisualStyleBackColor = true;
            this.BTN_INGRESAR.Click += new System.EventHandler(this.BTN_INGRESAR_Click);
            // 
            // TX_1
            // 
            this.TX_1.Location = new System.Drawing.Point(266, 66);
            this.TX_1.Name = "TX_1";
            this.TX_1.Size = new System.Drawing.Size(100, 20);
            this.TX_1.TabIndex = 2;
            // 
            // TX_RESULTADO
            // 
            this.TX_RESULTADO.Location = new System.Drawing.Point(176, 115);
            this.TX_RESULTADO.Name = "TX_RESULTADO";
            this.TX_RESULTADO.Size = new System.Drawing.Size(386, 20);
            this.TX_RESULTADO.TabIndex = 3;
            // 
            // BTN_MOSTRAR
            // 
            this.BTN_MOSTRAR.Location = new System.Drawing.Point(94, 112);
            this.BTN_MOSTRAR.Name = "BTN_MOSTRAR";
            this.BTN_MOSTRAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_MOSTRAR.TabIndex = 4;
            this.BTN_MOSTRAR.Text = "Mostrar";
            this.BTN_MOSTRAR.UseVisualStyleBackColor = true;
            this.BTN_MOSTRAR.Click += new System.EventHandler(this.BTN_MOSTRAR_Click);
            // 
            // LB_RESULTADO
            // 
            this.LB_RESULTADO.AutoSize = true;
            this.LB_RESULTADO.Location = new System.Drawing.Point(584, 122);
            this.LB_RESULTADO.Name = "LB_RESULTADO";
            this.LB_RESULTADO.Size = new System.Drawing.Size(0, 13);
            this.LB_RESULTADO.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 147);
            this.Controls.Add(this.LB_RESULTADO);
            this.Controls.Add(this.BTN_MOSTRAR);
            this.Controls.Add(this.TX_RESULTADO);
            this.Controls.Add(this.TX_1);
            this.Controls.Add(this.BTN_INGRESAR);
            this.Controls.Add(this.LB_ENUNCIADO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_ENUNCIADO;
        private System.Windows.Forms.Button BTN_INGRESAR;
        private System.Windows.Forms.TextBox TX_1;
        private System.Windows.Forms.TextBox TX_RESULTADO;
        private System.Windows.Forms.Button BTN_MOSTRAR;
        private System.Windows.Forms.Label LB_RESULTADO;
    }
}

