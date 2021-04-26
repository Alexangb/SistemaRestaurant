
namespace SistemaRestaurant.Modulos.Productos
{
    partial class GrupoDeProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrupoDeProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtgrupo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoximagengrupo = new System.Windows.Forms.PictureBox();
            this.panelagregaricono = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxclikicono = new System.Windows.Forms.PictureBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.dlg = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximagengrupo)).BeginInit();
            this.panelagregaricono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclikicono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(249, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grupo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 2);
            this.panel1.TabIndex = 2;
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Black;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.Location = new System.Drawing.Point(613, 14);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 43);
            this.btncerrar.TabIndex = 3;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnvolver);
            this.panel2.Controls.Add(this.btneliminar);
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.panelagregaricono);
            this.panel2.Controls.Add(this.pictureBoximagengrupo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtgrupo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 719);
            this.panel2.TabIndex = 4;
            // 
            // txtgrupo
            // 
            this.txtgrupo.BackColor = System.Drawing.Color.Black;
            this.txtgrupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtgrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrupo.ForeColor = System.Drawing.Color.White;
            this.txtgrupo.Location = new System.Drawing.Point(37, 41);
            this.txtgrupo.Multiline = true;
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(641, 58);
            this.txtgrupo.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(37, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 1);
            this.panel3.TabIndex = 1;
            // 
            // pictureBoximagengrupo
            // 
            this.pictureBoximagengrupo.Image = global::SistemaRestaurant.Properties.Resources.advertencia;
            this.pictureBoximagengrupo.Location = new System.Drawing.Point(83, 138);
            this.pictureBoximagengrupo.Name = "pictureBoximagengrupo";
            this.pictureBoximagengrupo.Size = new System.Drawing.Size(561, 311);
            this.pictureBoximagengrupo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoximagengrupo.TabIndex = 2;
            this.pictureBoximagengrupo.TabStop = false;
            // 
            // panelagregaricono
            // 
            this.panelagregaricono.Controls.Add(this.pictureBoxclikicono);
            this.panelagregaricono.Controls.Add(this.label3);
            this.panelagregaricono.Location = new System.Drawing.Point(83, 138);
            this.panelagregaricono.Name = "panelagregaricono";
            this.panelagregaricono.Size = new System.Drawing.Size(561, 311);
            this.panelagregaricono.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(561, 186);
            this.label3.TabIndex = 1;
            this.label3.Text = "Agregar Icono(Opcional)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBoxclikicono
            // 
            this.pictureBoxclikicono.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxclikicono.Image")));
            this.pictureBoxclikicono.Location = new System.Drawing.Point(3, 189);
            this.pictureBoxclikicono.Name = "pictureBoxclikicono";
            this.pictureBoxclikicono.Size = new System.Drawing.Size(555, 59);
            this.pictureBoxclikicono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxclikicono.TabIndex = 2;
            this.pictureBoxclikicono.TabStop = false;
            this.pictureBoxclikicono.Click += new System.EventHandler(this.pictureBoxclikicono_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(233, 455);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(237, 68);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(233, 529);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(237, 68);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.DimGray;
            this.btnvolver.FlatAppearance.BorderSize = 0;
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.Color.White;
            this.btnvolver.Location = new System.Drawing.Point(233, 603);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(237, 68);
            this.btnvolver.TabIndex = 6;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            // 
            // dlg
            // 
            this.dlg.FileName = "openFileDialog1";
            // 
            // GrupoDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(722, 829);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GrupoDeProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrupoDeProductos";
            this.Load += new System.EventHandler(this.GrupoDeProductos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximagengrupo)).EndInit();
            this.panelagregaricono.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclikicono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoximagengrupo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtgrupo;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Panel panelagregaricono;
        private System.Windows.Forms.PictureBox pictureBoxclikicono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog dlg;
    }
}