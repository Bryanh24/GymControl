namespace CapaPresentacion
{
    partial class AgregarEmpleado
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEliminarRegistro = new System.Windows.Forms.Button();
            this.btnActualizarRegistro = new System.Windows.Forms.Button();
            this.TablaEmpleados = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.ConsNombreEmpleado = new System.Windows.Forms.TextBox();
            this.ConsId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.ConsCorreoEmpleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.ConsCelularEmpleado = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ConsApellidoPaterno = new System.Windows.Forms.TextBox();
            this.ConsApellidoMaterno = new System.Windows.Forms.TextBox();
            this.BtnAgregarEmpleado = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEmpleados)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(218, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 56);
            this.label3.TabIndex = 11;
            this.label3.Text = "Empleados";
            // 
            // BtnEliminarRegistro
            // 
            this.BtnEliminarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnEliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarRegistro.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarRegistro.Location = new System.Drawing.Point(531, 474);
            this.BtnEliminarRegistro.Name = "BtnEliminarRegistro";
            this.BtnEliminarRegistro.Size = new System.Drawing.Size(100, 27);
            this.BtnEliminarRegistro.TabIndex = 25;
            this.BtnEliminarRegistro.Text = "Eliminar";
            this.BtnEliminarRegistro.UseVisualStyleBackColor = false;
            this.BtnEliminarRegistro.Click += new System.EventHandler(this.BtnEliminarRegistro_Click);
            // 
            // btnActualizarRegistro
            // 
            this.btnActualizarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnActualizarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnActualizarRegistro.Location = new System.Drawing.Point(415, 474);
            this.btnActualizarRegistro.Name = "btnActualizarRegistro";
            this.btnActualizarRegistro.Size = new System.Drawing.Size(100, 27);
            this.btnActualizarRegistro.TabIndex = 24;
            this.btnActualizarRegistro.Text = "Actualizar";
            this.btnActualizarRegistro.UseVisualStyleBackColor = false;
            this.btnActualizarRegistro.Click += new System.EventHandler(this.btnActualizarRegistro_Click);
            // 
            // TablaEmpleados
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TablaEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TablaEmpleados.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.TablaEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TablaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaEmpleados.DoubleBuffered = true;
            this.TablaEmpleados.EnableHeadersVisualStyles = false;
            this.TablaEmpleados.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.TablaEmpleados.HeaderForeColor = System.Drawing.Color.Black;
            this.TablaEmpleados.Location = new System.Drawing.Point(11, 136);
            this.TablaEmpleados.Name = "TablaEmpleados";
            this.TablaEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaEmpleados.Size = new System.Drawing.Size(621, 313);
            this.TablaEmpleados.TabIndex = 12;
            this.TablaEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaEmpleados_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(356, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "id";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lab.Location = new System.Drawing.Point(28, 15);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(84, 22);
            this.lab.TabIndex = 33;
            this.lab.Text = "Nombre";
            // 
            // ConsNombreEmpleado
            // 
            this.ConsNombreEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ConsNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsNombreEmpleado.ForeColor = System.Drawing.Color.White;
            this.ConsNombreEmpleado.Location = new System.Drawing.Point(118, 17);
            this.ConsNombreEmpleado.Name = "ConsNombreEmpleado";
            this.ConsNombreEmpleado.Size = new System.Drawing.Size(232, 20);
            this.ConsNombreEmpleado.TabIndex = 35;
            this.ConsNombreEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConsNombreEmpleado_KeyPress);
            // 
            // ConsId
            // 
            this.ConsId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ConsId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsId.ForeColor = System.Drawing.Color.White;
            this.ConsId.Location = new System.Drawing.Point(397, 15);
            this.ConsId.Name = "ConsId";
            this.ConsId.Size = new System.Drawing.Size(234, 20);
            this.ConsId.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(356, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Celular";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl.Location = new System.Drawing.Point(28, 51);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(162, 22);
            this.lbl.TabIndex = 38;
            this.lbl.Text = "Apellido Paterno";
            // 
            // ConsCorreoEmpleado
            // 
            this.ConsCorreoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ConsCorreoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsCorreoEmpleado.ForeColor = System.Drawing.Color.White;
            this.ConsCorreoEmpleado.Location = new System.Drawing.Point(435, 90);
            this.ConsCorreoEmpleado.Name = "ConsCorreoEmpleado";
            this.ConsCorreoEmpleado.Size = new System.Drawing.Size(196, 20);
            this.ConsCorreoEmpleado.TabIndex = 40;
            this.ConsCorreoEmpleado.Leave += new System.EventHandler(this.ConsCorreoEmpleado_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(356, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 42;
            this.label7.Text = "Correo";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl3.Location = new System.Drawing.Point(28, 87);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(168, 22);
            this.lbl3.TabIndex = 41;
            this.lbl3.Text = "Apellido Materno";
            // 
            // ConsCelularEmpleado
            // 
            this.ConsCelularEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ConsCelularEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsCelularEmpleado.ForeColor = System.Drawing.Color.White;
            this.ConsCelularEmpleado.Location = new System.Drawing.Point(436, 49);
            this.ConsCelularEmpleado.Name = "ConsCelularEmpleado";
            this.ConsCelularEmpleado.Size = new System.Drawing.Size(196, 20);
            this.ConsCelularEmpleado.TabIndex = 43;
            this.ConsCelularEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConsCelularEmpleado_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.BtnEliminarRegistro);
            this.panel2.Controls.Add(this.btnActualizarRegistro);
            this.panel2.Controls.Add(this.ConsApellidoPaterno);
            this.panel2.Controls.Add(this.ConsApellidoMaterno);
            this.panel2.Controls.Add(this.ConsCelularEmpleado);
            this.panel2.Controls.Add(this.BtnAgregarEmpleado);
            this.panel2.Controls.Add(this.lbl3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ConsCorreoEmpleado);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ConsId);
            this.panel2.Controls.Add(this.ConsNombreEmpleado);
            this.panel2.Controls.Add(this.lab);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TablaEmpleados);
            this.panel2.Location = new System.Drawing.Point(32, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 529);
            this.panel2.TabIndex = 11;
            // 
            // ConsApellidoPaterno
            // 
            this.ConsApellidoPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ConsApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsApellidoPaterno.ForeColor = System.Drawing.Color.White;
            this.ConsApellidoPaterno.Location = new System.Drawing.Point(196, 53);
            this.ConsApellidoPaterno.Name = "ConsApellidoPaterno";
            this.ConsApellidoPaterno.Size = new System.Drawing.Size(154, 20);
            this.ConsApellidoPaterno.TabIndex = 45;
            // 
            // ConsApellidoMaterno
            // 
            this.ConsApellidoMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ConsApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsApellidoMaterno.ForeColor = System.Drawing.Color.White;
            this.ConsApellidoMaterno.Location = new System.Drawing.Point(196, 90);
            this.ConsApellidoMaterno.Name = "ConsApellidoMaterno";
            this.ConsApellidoMaterno.Size = new System.Drawing.Size(154, 20);
            this.ConsApellidoMaterno.TabIndex = 44;
            // 
            // BtnAgregarEmpleado
            // 
            this.BtnAgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarEmpleado.Location = new System.Drawing.Point(294, 474);
            this.BtnAgregarEmpleado.Name = "BtnAgregarEmpleado";
            this.BtnAgregarEmpleado.Size = new System.Drawing.Size(100, 27);
            this.BtnAgregarEmpleado.TabIndex = 10;
            this.BtnAgregarEmpleado.Text = "Agregar";
            this.BtnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.BtnAgregarEmpleado.Click += new System.EventHandler(this.BtnAgregarEmpleado_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.AutoEllipsis = true;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnExit.Location = new System.Drawing.Point(1310, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 12;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(588, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 46;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(700, 658);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarEmpleado";
            this.Text = "AgregarEmpleado";
            this.Load += new System.EventHandler(this.AgregarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaEmpleados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEliminarRegistro;
        private System.Windows.Forms.Button btnActualizarRegistro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ConsApellidoPaterno;
        private System.Windows.Forms.TextBox ConsApellidoMaterno;
        private System.Windows.Forms.TextBox ConsCelularEmpleado;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ConsCorreoEmpleado;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConsId;
        private System.Windows.Forms.TextBox ConsNombreEmpleado;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid TablaEmpleados;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAgregarEmpleado;
        private System.Windows.Forms.Button button1;
    }
}