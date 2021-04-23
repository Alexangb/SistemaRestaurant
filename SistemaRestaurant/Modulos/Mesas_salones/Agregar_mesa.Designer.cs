
namespace SistemaRestaurant.Modulos.Mesas_salones
{
    partial class Agregar_mesa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmesaedicion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnguardarmesa = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesa";
            // 
            // txtmesaedicion
            // 
            this.txtmesaedicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmesaedicion.Location = new System.Drawing.Point(122, 109);
            this.txtmesaedicion.Name = "txtmesaedicion";
            this.txtmesaedicion.Size = new System.Drawing.Size(294, 45);
            this.txtmesaedicion.TabIndex = 1;
            this.txtmesaedicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(123, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 1);
            this.panel1.TabIndex = 2;
            // 
            // btnguardarmesa
            // 
            this.btnguardarmesa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnguardarmesa.FlatAppearance.BorderSize = 0;
            this.btnguardarmesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarmesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarmesa.ForeColor = System.Drawing.Color.White;
            this.btnguardarmesa.Location = new System.Drawing.Point(122, 196);
            this.btnguardarmesa.Name = "btnguardarmesa";
            this.btnguardarmesa.Size = new System.Drawing.Size(294, 86);
            this.btnguardarmesa.TabIndex = 3;
            this.btnguardarmesa.Text = "Guardar";
            this.btnguardarmesa.UseVisualStyleBackColor = false;
            this.btnguardarmesa.Click += new System.EventHandler(this.btnguardarmesa_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(122, 288);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(294, 86);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnvolver.FlatAppearance.BorderSize = 0;
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.Color.White;
            this.btnvolver.Location = new System.Drawing.Point(122, 380);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(294, 86);
            this.btnvolver.TabIndex = 5;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Black;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.Location = new System.Drawing.Point(471, 2);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(67, 56);
            this.btncerrar.TabIndex = 6;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Agregar_mesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(539, 511);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardarmesa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtmesaedicion);
            this.Controls.Add(this.label1);
            this.Name = "Agregar_mesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Agregar_mesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmesaedicion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnguardarmesa;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btncerrar;
    }
}