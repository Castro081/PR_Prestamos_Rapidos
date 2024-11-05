namespace ProyectoPrestamo.Formularios
{
    partial class frmHistorialAhorro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvahorro = new System.Windows.Forms.DataGridView();
            this.txtidprestamo = new System.Windows.Forms.TextBox();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btnvolver = new FontAwesome.Sharp.IconButton();
            this.btndescargarresumen = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtclientedireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtclientecorreo = new System.Windows.Forms.TextBox();
            this.txtclienteciudad = new System.Windows.Forms.TextBox();
            this.txtclientetelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtclientedocumento = new System.Windows.Forms.TextBox();
            this.txtclientetipodocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtclientenombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdocumentocliente = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.rbdocumentocliente = new System.Windows.Forms.RadioButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtmontoxcuota = new System.Windows.Forms.TextBox();
            this.txtmontototalpagar = new System.Windows.Forms.TextBox();
            this.txtmontoprestamo = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.txtnumerooperacion = new System.Windows.Forms.TextBox();
            this.rbnumerooperacion = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.lblestadoprestamo = new System.Windows.Forms.Label();
            this.lblnrooperacion = new System.Windows.Forms.Label();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAhorrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbotipomoneda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvahorro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.dgvahorro);
            this.groupBox5.Location = new System.Drawing.Point(505, 133);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(501, 309);
            this.groupBox5.TabIndex = 109;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resumen Cuotas";
            // 
            // dgvahorro
            // 
            this.dgvahorro.AllowUserToAddRows = false;
            this.dgvahorro.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvahorro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvahorro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvahorro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Monto,
            this.FechaPago,
            this.TotalAhorrado});
            this.dgvahorro.Location = new System.Drawing.Point(10, 20);
            this.dgvahorro.MultiSelect = false;
            this.dgvahorro.Name = "dgvahorro";
            this.dgvahorro.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dgvahorro.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvahorro.RowTemplate.Height = 24;
            this.dgvahorro.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvahorro.Size = new System.Drawing.Size(479, 278);
            this.dgvahorro.TabIndex = 89;
            // 
            // txtidprestamo
            // 
            this.txtidprestamo.Location = new System.Drawing.Point(990, 9);
            this.txtidprestamo.Name = "txtidprestamo";
            this.txtidprestamo.Size = new System.Drawing.Size(25, 20);
            this.txtidprestamo.TabIndex = 100;
            this.txtidprestamo.Text = "0";
            this.txtidprestamo.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btncancelar.IconColor = System.Drawing.Color.Black;
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btncancelar.IconSize = 50;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.Location = new System.Drawing.Point(724, 448);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(106, 83);
            this.btncancelar.TabIndex = 108;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnvolver
            // 
            this.btnvolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.btnvolver.IconColor = System.Drawing.Color.Black;
            this.btnvolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnvolver.IconSize = 50;
            this.btnvolver.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnvolver.Location = new System.Drawing.Point(836, 448);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(106, 83);
            this.btnvolver.TabIndex = 107;
            this.btnvolver.Text = "Volver";
            this.btnvolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnvolver.UseVisualStyleBackColor = true;
            // 
            // btndescargarresumen
            // 
            this.btndescargarresumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndescargarresumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescargarresumen.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btndescargarresumen.IconColor = System.Drawing.Color.Black;
            this.btndescargarresumen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndescargarresumen.IconSize = 45;
            this.btndescargarresumen.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndescargarresumen.Location = new System.Drawing.Point(601, 448);
            this.btndescargarresumen.Name = "btndescargarresumen";
            this.btndescargarresumen.Size = new System.Drawing.Size(106, 83);
            this.btndescargarresumen.TabIndex = 106;
            this.btndescargarresumen.Text = "Descargar";
            this.btndescargarresumen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndescargarresumen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtclientedireccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtclientecorreo);
            this.groupBox1.Controls.Add(this.txtclienteciudad);
            this.groupBox1.Controls.Add(this.txtclientetelefono);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtclientedocumento);
            this.groupBox1.Controls.Add(this.txtclientetipodocumento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtclientenombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 164);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACIÓN DEL CLIENTE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(215, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Ciudad:";
            // 
            // txtclientedireccion
            // 
            this.txtclientedireccion.Location = new System.Drawing.Point(14, 86);
            this.txtclientedireccion.Name = "txtclientedireccion";
            this.txtclientedireccion.ReadOnly = true;
            this.txtclientedireccion.Size = new System.Drawing.Size(187, 20);
            this.txtclientedireccion.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Dirección:";
            // 
            // txtclientecorreo
            // 
            this.txtclientecorreo.Location = new System.Drawing.Point(334, 86);
            this.txtclientecorreo.Name = "txtclientecorreo";
            this.txtclientecorreo.ReadOnly = true;
            this.txtclientecorreo.Size = new System.Drawing.Size(132, 20);
            this.txtclientecorreo.TabIndex = 6;
            // 
            // txtclienteciudad
            // 
            this.txtclienteciudad.Location = new System.Drawing.Point(216, 86);
            this.txtclienteciudad.Name = "txtclienteciudad";
            this.txtclienteciudad.ReadOnly = true;
            this.txtclienteciudad.Size = new System.Drawing.Size(104, 20);
            this.txtclienteciudad.TabIndex = 5;
            // 
            // txtclientetelefono
            // 
            this.txtclientetelefono.Location = new System.Drawing.Point(14, 133);
            this.txtclientetelefono.Name = "txtclientetelefono";
            this.txtclientetelefono.ReadOnly = true;
            this.txtclientetelefono.Size = new System.Drawing.Size(187, 20);
            this.txtclientetelefono.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(331, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Correo Electronico:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Numero Telefono / Celular:";
            // 
            // txtclientedocumento
            // 
            this.txtclientedocumento.Location = new System.Drawing.Point(334, 40);
            this.txtclientedocumento.Name = "txtclientedocumento";
            this.txtclientedocumento.ReadOnly = true;
            this.txtclientedocumento.Size = new System.Drawing.Size(132, 20);
            this.txtclientedocumento.TabIndex = 3;
            // 
            // txtclientetipodocumento
            // 
            this.txtclientetipodocumento.Location = new System.Drawing.Point(216, 40);
            this.txtclientetipodocumento.Name = "txtclientetipodocumento";
            this.txtclientetipodocumento.ReadOnly = true;
            this.txtclientetipodocumento.Size = new System.Drawing.Size(104, 20);
            this.txtclientetipodocumento.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(331, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número Documento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(213, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tipo Documento:";
            // 
            // txtclientenombre
            // 
            this.txtclientenombre.Location = new System.Drawing.Point(14, 40);
            this.txtclientenombre.Name = "txtclientenombre";
            this.txtclientenombre.ReadOnly = true;
            this.txtclientenombre.Size = new System.Drawing.Size(187, 20);
            this.txtclientenombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre Completo:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtdocumentocliente);
            this.groupBox2.Controls.Add(this.iconButton2);
            this.groupBox2.Controls.Add(this.rbdocumentocliente);
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Location = new System.Drawing.Point(15, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(991, 49);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            // 
            // txtdocumentocliente
            // 
            this.txtdocumentocliente.BackColor = System.Drawing.Color.White;
            this.txtdocumentocliente.Location = new System.Drawing.Point(146, 17);
            this.txtdocumentocliente.Name = "txtdocumentocliente";
            this.txtdocumentocliente.Size = new System.Drawing.Size(100, 20);
            this.txtdocumentocliente.TabIndex = 65;
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton2.Location = new System.Drawing.Point(296, 15);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(37, 23);
            this.iconButton2.TabIndex = 59;
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // rbdocumentocliente
            // 
            this.rbdocumentocliente.AutoSize = true;
            this.rbdocumentocliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbdocumentocliente.Location = new System.Drawing.Point(14, 18);
            this.rbdocumentocliente.Name = "rbdocumentocliente";
            this.rbdocumentocliente.Size = new System.Drawing.Size(133, 17);
            this.rbdocumentocliente.TabIndex = 12;
            this.rbdocumentocliente.Text = "Nº Documento Cliente:";
            this.rbdocumentocliente.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 19;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscar.Location = new System.Drawing.Point(253, 15);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(37, 23);
            this.btnbuscar.TabIndex = 10;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(1010, 52);
            this.label2.TabIndex = 102;
            this.label2.Text = "Historial de Ahorro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1010, 481);
            this.label1.TabIndex = 101;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(32, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Monto Prestamo:";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(14, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(452, 10);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(84, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Multa:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(250, 148);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(103, 13);
            this.label25.TabIndex = 62;
            this.label25.Text = "Monto Total ahorrar:";
            // 
            // txtmontoxcuota
            // 
            this.txtmontoxcuota.Location = new System.Drawing.Point(87, 164);
            this.txtmontoxcuota.Name = "txtmontoxcuota";
            this.txtmontoxcuota.ReadOnly = true;
            this.txtmontoxcuota.Size = new System.Drawing.Size(116, 20);
            this.txtmontoxcuota.TabIndex = 80;
            // 
            // txtmontototalpagar
            // 
            this.txtmontototalpagar.Location = new System.Drawing.Point(253, 164);
            this.txtmontototalpagar.Name = "txtmontototalpagar";
            this.txtmontototalpagar.ReadOnly = true;
            this.txtmontototalpagar.Size = new System.Drawing.Size(104, 20);
            this.txtmontototalpagar.TabIndex = 82;
            // 
            // txtmontoprestamo
            // 
            this.txtmontoprestamo.Location = new System.Drawing.Point(35, 64);
            this.txtmontoprestamo.Name = "txtmontoprestamo";
            this.txtmontoprestamo.ReadOnly = true;
            this.txtmontoprestamo.Size = new System.Drawing.Size(116, 20);
            this.txtmontoprestamo.TabIndex = 86;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(-263, -156);
            this.label34.Name = "label34";
            this.label34.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label34.Size = new System.Drawing.Size(1010, 52);
            this.label34.TabIndex = 102;
            this.label34.Text = "Historial de Préstamo";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.White;
            this.groupBox10.Controls.Add(this.lblnrooperacion);
            this.groupBox10.Controls.Add(this.lblestadoprestamo);
            this.groupBox10.Controls.Add(this.textBox14);
            this.groupBox10.Controls.Add(this.label32);
            this.groupBox10.Controls.Add(this.label33);
            this.groupBox10.Controls.Add(this.iconButton7);
            this.groupBox10.Controls.Add(this.radioButton1);
            this.groupBox10.Controls.Add(this.rbnumerooperacion);
            this.groupBox10.Controls.Add(this.txtnumerooperacion);
            this.groupBox10.Controls.Add(this.iconButton8);
            this.groupBox10.Location = new System.Drawing.Point(-253, -96);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(991, 49);
            this.groupBox10.TabIndex = 103;
            this.groupBox10.TabStop = false;
            // 
            // iconButton8
            // 
            this.iconButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 19;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton8.Location = new System.Drawing.Point(447, 17);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(37, 23);
            this.iconButton8.TabIndex = 10;
            this.iconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton8.UseVisualStyleBackColor = true;
            // 
            // txtnumerooperacion
            // 
            this.txtnumerooperacion.BackColor = System.Drawing.Color.White;
            this.txtnumerooperacion.Location = new System.Drawing.Point(101, 19);
            this.txtnumerooperacion.Name = "txtnumerooperacion";
            this.txtnumerooperacion.Size = new System.Drawing.Size(100, 20);
            this.txtnumerooperacion.TabIndex = 0;
            // 
            // rbnumerooperacion
            // 
            this.rbnumerooperacion.AutoSize = true;
            this.rbnumerooperacion.Checked = true;
            this.rbnumerooperacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbnumerooperacion.Location = new System.Drawing.Point(9, 20);
            this.rbnumerooperacion.Name = "rbnumerooperacion";
            this.rbnumerooperacion.Size = new System.Drawing.Size(92, 17);
            this.rbnumerooperacion.TabIndex = 11;
            this.rbnumerooperacion.TabStop = true;
            this.rbnumerooperacion.Text = "Nº Operación:";
            this.rbnumerooperacion.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(208, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.Text = "Nº Documento Cliente:";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton7
            // 
            this.iconButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 20;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton7.Location = new System.Drawing.Point(490, 17);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(37, 23);
            this.iconButton7.TabIndex = 59;
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(554, 22);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(74, 13);
            this.label33.TabIndex = 90;
            this.label33.Text = "Nº Operación:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(701, 22);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(90, 13);
            this.label32.TabIndex = 96;
            this.label32.Text = "Estado Préstamo:";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.White;
            this.textBox14.Location = new System.Drawing.Point(340, 19);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 65;
            // 
            // lblestadoprestamo
            // 
            this.lblestadoprestamo.AutoSize = true;
            this.lblestadoprestamo.BackColor = System.Drawing.Color.White;
            this.lblestadoprestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadoprestamo.Location = new System.Drawing.Point(793, 20);
            this.lblestadoprestamo.Name = "lblestadoprestamo";
            this.lblestadoprestamo.Size = new System.Drawing.Size(78, 15);
            this.lblestadoprestamo.TabIndex = 97;
            this.lblestadoprestamo.Text = "EN CURSO";
            // 
            // lblnrooperacion
            // 
            this.lblnrooperacion.AutoSize = true;
            this.lblnrooperacion.BackColor = System.Drawing.Color.White;
            this.lblnrooperacion.Location = new System.Drawing.Point(629, 23);
            this.lblnrooperacion.Name = "lblnrooperacion";
            this.lblnrooperacion.Size = new System.Drawing.Size(43, 13);
            this.lblnrooperacion.TabIndex = 91;
            this.lblnrooperacion.Text = "000000";
            // 
            // iconButton5
            // 
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 45;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton5.Location = new System.Drawing.Point(237, 283);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(106, 83);
            this.iconButton5.TabIndex = 106;
            this.iconButton5.Text = "Descargar";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 50;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton4.Location = new System.Drawing.Point(632, 283);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(106, 83);
            this.iconButton4.TabIndex = 107;
            this.iconButton4.Text = "Volver";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton3.IconSize = 50;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.Location = new System.Drawing.Point(500, 283);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(106, 83);
            this.iconButton3.TabIndex = 108;
            this.iconButton3.Text = "Cancelar";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(722, -156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 100;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 45;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(369, 283);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(106, 83);
            this.iconButton1.TabIndex = 110;
            this.iconButton1.Text = "Modificar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtfechainicio);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbotipomoneda);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.iconButton1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.iconButton3);
            this.groupBox3.Controls.Add(this.iconButton4);
            this.groupBox3.Controls.Add(this.iconButton5);
            this.groupBox3.Controls.Add(this.groupBox10);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.txtmontoprestamo);
            this.groupBox3.Controls.Add(this.txtmontototalpagar);
            this.groupBox3.Controls.Add(this.txtmontoxcuota);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Location = new System.Drawing.Point(15, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 220);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INFORMACIÓN DEL AHORRO";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Monto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Monto.Width = 90;
            // 
            // FechaPago
            // 
            this.FechaPago.HeaderText = "Fecha ";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            this.FechaPago.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaPago.Width = 90;
            // 
            // TotalAhorrado
            // 
            this.TotalAhorrado.HeaderText = "Total Ahorrado";
            this.TotalAhorrado.Name = "TotalAhorrado";
            this.TotalAhorrado.ReadOnly = true;
            this.TotalAhorrado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalAhorrado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cbotipomoneda
            // 
            this.cbotipomoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipomoneda.FormattingEnabled = true;
            this.cbotipomoneda.Location = new System.Drawing.Point(176, 64);
            this.cbotipomoneda.Name = "cbotipomoneda";
            this.cbotipomoneda.Size = new System.Drawing.Size(106, 21);
            this.cbotipomoneda.TabIndex = 112;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(173, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 111;
            this.label11.Text = "Tipo Moneda:";
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(310, 64);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(97, 20);
            this.txtfechainicio.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(307, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 114;
            this.label4.Text = "Fecha Inicio:";
            // 
            // frmHistorialAhorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 550);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtidprestamo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btndescargarresumen);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHistorialAhorro";
            this.Text = "frmHistorialAhorro";
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvahorro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvahorro;
        private System.Windows.Forms.TextBox txtidprestamo;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btnvolver;
        private FontAwesome.Sharp.IconButton btndescargarresumen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtclientedireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtclientecorreo;
        private System.Windows.Forms.TextBox txtclienteciudad;
        private System.Windows.Forms.TextBox txtclientetelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtclientedocumento;
        private System.Windows.Forms.TextBox txtclientetipodocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtclientenombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdocumentocliente;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.RadioButton rbdocumentocliente;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtmontoxcuota;
        private System.Windows.Forms.TextBox txtmontototalpagar;
        private System.Windows.Forms.TextBox txtmontoprestamo;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblnrooperacion;
        private System.Windows.Forms.Label lblestadoprestamo;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbnumerooperacion;
        private System.Windows.Forms.TextBox txtnumerooperacion;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAhorrado;
        private System.Windows.Forms.ComboBox cbotipomoneda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.Label label4;
    }
}