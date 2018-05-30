namespace CapaPresentacion
{
    partial class AgregarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnAgregarEmpleado = new System.Windows.Forms.Button();
            this.BtnEliminarRegistro = new System.Windows.Forms.Button();
            this.btnActualizarRegistro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ConsultarCorreoCliente = new System.Windows.Forms.TextBox();
            this.ConsApellidoMaternoCliente = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ConsultarCelularCliente = new System.Windows.Forms.TextBox();
            this.ConsApellidoPaternoCliente = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConsultarIdCliente = new System.Windows.Forms.TextBox();
            this.ConsultarNombreCliente = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TablaClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregarEmpleado
            // 
            this.BtnAgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarEmpleado.Location = new System.Drawing.Point(329, 557);
            this.BtnAgregarEmpleado.Name = "BtnAgregarEmpleado";
            this.BtnAgregarEmpleado.Size = new System.Drawing.Size(97, 32);
            this.BtnAgregarEmpleado.TabIndex = 10;
            this.BtnAgregarEmpleado.Text = "Agregar";
            this.BtnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.BtnAgregarEmpleado.Click += new System.EventHandler(this.BtnAgregarEmpleado_Click);
            // 
            // BtnEliminarRegistro
            // 
            this.BtnEliminarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnEliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarRegistro.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarRegistro.Location = new System.Drawing.Point(597, 557);
            this.BtnEliminarRegistro.Name = "BtnEliminarRegistro";
            this.BtnEliminarRegistro.Size = new System.Drawing.Size(84, 32);
            this.BtnEliminarRegistro.TabIndex = 25;
            this.BtnEliminarRegistro.Text = "Eliminar";
            this.BtnEliminarRegistro.UseVisualStyleBackColor = false;
            this.BtnEliminarRegistro.Click += new System.EventHandler(this.BtnEliminarRegistro_Click);
            // 
            // btnActualizarRegistro
            // 
            this.btnActualizarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnActualizarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnActualizarRegistro.Location = new System.Drawing.Point(464, 557);
            this.btnActualizarRegistro.Name = "btnActualizarRegistro";
            this.btnActualizarRegistro.Size = new System.Drawing.Size(101, 32);
            this.btnActualizarRegistro.TabIndex = 24;
            this.btnActualizarRegistro.Text = "Actualizar";
            this.btnActualizarRegistro.UseVisualStyleBackColor = false;
            this.btnActualizarRegistro.Click += new System.EventHandler(this.btnActualizarRegistro_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.BtnEliminarRegistro);
            this.panel2.Controls.Add(this.ConsultarCorreoCliente);
            this.panel2.Controls.Add(this.btnActualizarRegistro);
            this.panel2.Controls.Add(this.ConsApellidoMaternoCliente);
            this.panel2.Controls.Add(this.lbl3);
            this.panel2.Controls.Add(this.BtnAgregarEmpleado);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ConsultarCelularCliente);
            this.panel2.Controls.Add(this.ConsApellidoPaternoCliente);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ConsultarIdCliente);
            this.panel2.Controls.Add(this.ConsultarNombreCliente);
            this.panel2.Controls.Add(this.lab);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TablaClientes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(36, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 614);
            this.panel2.TabIndex = 12;
            // 
            // ConsultarCorreoCliente
            // 
            this.ConsultarCorreoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ConsultarCorreoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultarCorreoCliente.ForeColor = System.Drawing.Color.White;
            this.ConsultarCorreoCliente.Location = new System.Drawing.Point(111, 151);
            this.ConsultarCorreoCliente.Name = "ConsultarCorreoCliente";
            this.ConsultarCorreoCliente.Size = new System.Drawing.Size(203, 20);
            this.ConsultarCorreoCliente.TabIndex = 32;
            // 
            // ConsApellidoMaternoCliente
            // 
            this.ConsApellidoMaternoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ConsApellidoMaternoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsApellidoMaternoCliente.ForeColor = System.Drawing.Color.White;
            this.ConsApellidoMaternoCliente.Location = new System.Drawing.Point(537, 104);
            this.ConsApellidoMaternoCliente.Name = "ConsApellidoMaternoCliente";
            this.ConsApellidoMaternoCliente.Size = new System.Drawing.Size(144, 20);
            this.ConsApellidoMaternoCliente.TabIndex = 31;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl3.Location = new System.Drawing.Point(363, 104);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(168, 22);
            this.lbl3.TabIndex = 29;
            this.lbl3.Text = "Apellido Materno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(363, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Correo";
            // 
            // ConsultarCelularCliente
            // 
            this.ConsultarCelularCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ConsultarCelularCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultarCelularCliente.ForeColor = System.Drawing.Color.White;
            this.ConsultarCelularCliente.Location = new System.Drawing.Point(446, 148);
            this.ConsultarCelularCliente.Name = "ConsultarCelularCliente";
            this.ConsultarCelularCliente.Size = new System.Drawing.Size(235, 20);
            this.ConsultarCelularCliente.TabIndex = 28;
            // 
            // ConsApellidoPaternoCliente
            // 
            this.ConsApellidoPaternoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ConsApellidoPaternoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsApellidoPaternoCliente.ForeColor = System.Drawing.Color.White;
            this.ConsApellidoPaternoCliente.Location = new System.Drawing.Point(185, 110);
            this.ConsApellidoPaternoCliente.Name = "ConsApellidoPaternoCliente";
            this.ConsApellidoPaternoCliente.Size = new System.Drawing.Size(129, 20);
            this.ConsApellidoPaternoCliente.TabIndex = 27;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl.Location = new System.Drawing.Point(17, 110);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(162, 22);
            this.lbl.TabIndex = 25;
            this.lbl.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(17, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Celular";
            // 
            // ConsultarIdCliente
            // 
            this.ConsultarIdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ConsultarIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultarIdCliente.ForeColor = System.Drawing.Color.White;
            this.ConsultarIdCliente.Location = new System.Drawing.Point(49, 76);
            this.ConsultarIdCliente.Name = "ConsultarIdCliente";
            this.ConsultarIdCliente.Size = new System.Drawing.Size(265, 20);
            this.ConsultarIdCliente.TabIndex = 23;
            // 
            // ConsultarNombreCliente
            // 
            this.ConsultarNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ConsultarNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultarNombreCliente.ForeColor = System.Drawing.Color.White;
            this.ConsultarNombreCliente.Location = new System.Drawing.Point(492, 78);
            this.ConsultarNombreCliente.Name = "ConsultarNombreCliente";
            this.ConsultarNombreCliente.Size = new System.Drawing.Size(189, 20);
            this.ConsultarNombreCliente.TabIndex = 19;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lab.Location = new System.Drawing.Point(363, 71);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(84, 22);
            this.lab.TabIndex = 13;
            this.lab.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(17, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "id";
            // 
            // TablaClientes
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TablaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.TablaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaClientes.DoubleBuffered = true;
            this.TablaClientes.EnableHeadersVisualStyles = false;
            this.TablaClientes.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TablaClientes.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.TablaClientes.HeaderForeColor = System.Drawing.Color.Black;
            this.TablaClientes.Location = new System.Drawing.Point(21, 187);
            this.TablaClientes.Name = "TablaClientes";
            this.TablaClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaClientes.Size = new System.Drawing.Size(660, 352);
            this.TablaClientes.TabIndex = 12;
            this.TablaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaClientes_CellClick);
            this.TablaClientes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaEmpleados_CellEndEdit);
            this.TablaClientes.Click += new System.EventHandler(this.TablaClientes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(250, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 58);
            this.label2.TabIndex = 10;
            this.label2.Text = "Clientes";
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(787, 638);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEliminarRegistro;
        private System.Windows.Forms.Button btnActualizarRegistro;
        private System.Windows.Forms.Button BtnAgregarEmpleado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ConsultarIdCliente;
        private System.Windows.Forms.TextBox ConsultarNombreCliente;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCustomDataGrid TablaClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ConsultarCorreoCliente;
        private System.Windows.Forms.TextBox ConsApellidoMaternoCliente;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ConsultarCelularCliente;
        private System.Windows.Forms.TextBox ConsApellidoPaternoCliente;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label4;
    }
}