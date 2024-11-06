namespace ProyectoPrestamo.Formularios
{
    partial class frmAhorro
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
            this.btnvolver = new FontAwesome.Sharp.IconButton();
            this.txtidprestamo = new System.Windows.Forms.TextBox();
            this.btnAhorrar = new FontAwesome.Sharp.IconButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtimportepagar = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtfechalimite = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtcuotapagar = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtmontoprestamo = new System.Windows.Forms.TextBox();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbotipomoneda = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtclientedireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtclientecorreo = new System.Windows.Forms.TextBox();
            this.txtclienteciudad = new System.Windows.Forms.TextBox();
            this.txtclientetelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtclientedocumento = new System.Windows.Forms.TextBox();
            this.txtclientetipodocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtclientenombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnrodocumento = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.btnborrar = new FontAwesome.Sharp.IconButton();
            this.rbdocumentocliente = new System.Windows.Forms.RadioButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnvolver.Location = new System.Drawing.Point(521, 374);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(106, 83);
            this.btnvolver.TabIndex = 95;
            this.btnvolver.Text = "Volver";
            this.btnvolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // txtidprestamo
            // 
            this.txtidprestamo.Location = new System.Drawing.Point(727, -1);
            this.txtidprestamo.Name = "txtidprestamo";
            this.txtidprestamo.Size = new System.Drawing.Size(25, 20);
            this.txtidprestamo.TabIndex = 93;
            this.txtidprestamo.Text = "0";
            this.txtidprestamo.Visible = false;
            // 
            // btnAhorrar
            // 
            this.btnAhorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAhorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAhorrar.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnAhorrar.IconColor = System.Drawing.Color.Black;
            this.btnAhorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAhorrar.IconSize = 50;
            this.btnAhorrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAhorrar.Location = new System.Drawing.Point(521, 272);
            this.btnAhorrar.Name = "btnAhorrar";
            this.btnAhorrar.Size = new System.Drawing.Size(106, 83);
            this.btnAhorrar.TabIndex = 94;
            this.btnAhorrar.Text = "Ahorrar";
            this.btnAhorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAhorrar.UseVisualStyleBackColor = true;
            this.btnAhorrar.Click += new System.EventHandler(this.btnAhorrar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.txtimportepagar);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.txtfechalimite);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.txtcuotapagar);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Location = new System.Drawing.Point(329, 276);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(147, 189);
            this.groupBox5.TabIndex = 92;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "INFORMACIÓN DE AHORRO";
            this.groupBox5.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(16, 119);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(116, 10);
            this.groupBox6.TabIndex = 60;
            this.groupBox6.TabStop = false;
            // 
            // txtimportepagar
            // 
            this.txtimportepagar.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtimportepagar.Location = new System.Drawing.Point(16, 151);
            this.txtimportepagar.Name = "txtimportepagar";
            this.txtimportepagar.ReadOnly = true;
            this.txtimportepagar.Size = new System.Drawing.Size(116, 20);
            this.txtimportepagar.TabIndex = 21;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(13, 135);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 20;
            this.label26.Text = "Total:";
            // 
            // txtfechalimite
            // 
            this.txtfechalimite.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtfechalimite.Location = new System.Drawing.Point(16, 97);
            this.txtfechalimite.Name = "txtfechalimite";
            this.txtfechalimite.ReadOnly = true;
            this.txtfechalimite.Size = new System.Drawing.Size(116, 20);
            this.txtfechalimite.TabIndex = 16;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(13, 81);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(98, 13);
            this.label28.TabIndex = 15;
            this.label28.Text = "Fecha Limite Pago:";
            // 
            // txtcuotapagar
            // 
            this.txtcuotapagar.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtcuotapagar.Location = new System.Drawing.Point(16, 47);
            this.txtcuotapagar.Name = "txtcuotapagar";
            this.txtcuotapagar.ReadOnly = true;
            this.txtcuotapagar.Size = new System.Drawing.Size(116, 20);
            this.txtcuotapagar.TabIndex = 14;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(13, 31);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(36, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Multa:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtmontoprestamo);
            this.groupBox3.Controls.Add(this.txtfechainicio);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbotipomoneda);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Location = new System.Drawing.Point(22, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 189);
            this.groupBox3.TabIndex = 91;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "APORTACIÓN";
            // 
            // txtmontoprestamo
            // 
            this.txtmontoprestamo.BackColor = System.Drawing.Color.White;
            this.txtmontoprestamo.Location = new System.Drawing.Point(83, 52);
            this.txtmontoprestamo.Name = "txtmontoprestamo";
            this.txtmontoprestamo.Size = new System.Drawing.Size(106, 20);
            this.txtmontoprestamo.TabIndex = 66;
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(83, 154);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(97, 20);
            this.txtfechainicio.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Fecha Inicio:";
            // 
            // cbotipomoneda
            // 
            this.cbotipomoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipomoneda.FormattingEnabled = true;
            this.cbotipomoneda.Location = new System.Drawing.Point(83, 101);
            this.cbotipomoneda.Name = "cbotipomoneda";
            this.cbotipomoneda.Size = new System.Drawing.Size(106, 21);
            this.cbotipomoneda.TabIndex = 88;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(80, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 87;
            this.label14.Text = "Tipo Moneda:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(162, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "(*)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(77, 36);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Monto ahorrar:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtclientedireccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtclientecorreo);
            this.groupBox1.Controls.Add(this.txtclienteciudad);
            this.groupBox1.Controls.Add(this.txtclientetelefono);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtclientedocumento);
            this.groupBox1.Controls.Add(this.txtclientetipodocumento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtclientenombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(22, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 121);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACIÓN DEL CLIENTE";
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
            this.txtclientecorreo.Location = new System.Drawing.Point(393, 86);
            this.txtclientecorreo.Name = "txtclientecorreo";
            this.txtclientecorreo.ReadOnly = true;
            this.txtclientecorreo.Size = new System.Drawing.Size(132, 20);
            this.txtclientecorreo.TabIndex = 6;
            // 
            // txtclienteciudad
            // 
            this.txtclienteciudad.Location = new System.Drawing.Point(222, 86);
            this.txtclienteciudad.Name = "txtclienteciudad";
            this.txtclienteciudad.ReadOnly = true;
            this.txtclienteciudad.Size = new System.Drawing.Size(149, 20);
            this.txtclienteciudad.TabIndex = 5;
            // 
            // txtclientetelefono
            // 
            this.txtclientetelefono.Location = new System.Drawing.Point(545, 86);
            this.txtclientetelefono.Name = "txtclientetelefono";
            this.txtclientetelefono.ReadOnly = true;
            this.txtclientetelefono.Size = new System.Drawing.Size(142, 20);
            this.txtclientetelefono.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(219, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ciudad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(390, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Correo Electronico:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(542, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Numero Telefono / Celular:";
            // 
            // txtclientedocumento
            // 
            this.txtclientedocumento.Location = new System.Drawing.Point(393, 40);
            this.txtclientedocumento.Name = "txtclientedocumento";
            this.txtclientedocumento.ReadOnly = true;
            this.txtclientedocumento.Size = new System.Drawing.Size(132, 20);
            this.txtclientedocumento.TabIndex = 3;
            // 
            // txtclientetipodocumento
            // 
            this.txtclientetipodocumento.Location = new System.Drawing.Point(222, 40);
            this.txtclientetipodocumento.Name = "txtclientetipodocumento";
            this.txtclientetipodocumento.ReadOnly = true;
            this.txtclientetipodocumento.Size = new System.Drawing.Size(149, 20);
            this.txtclientetipodocumento.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(390, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número Documento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(219, 24);
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
            this.groupBox2.Controls.Add(this.txtnrodocumento);
            this.groupBox2.Controls.Add(this.lblestado);
            this.groupBox2.Controls.Add(this.btnborrar);
            this.groupBox2.Controls.Add(this.rbdocumentocliente);
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Location = new System.Drawing.Point(22, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 49);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            // 
            // txtnrodocumento
            // 
            this.txtnrodocumento.BackColor = System.Drawing.Color.White;
            this.txtnrodocumento.Location = new System.Drawing.Point(148, 17);
            this.txtnrodocumento.Name = "txtnrodocumento";
            this.txtnrodocumento.Size = new System.Drawing.Size(100, 20);
            this.txtnrodocumento.TabIndex = 65;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(770, 24);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(0, 13);
            this.lblestado.TabIndex = 61;
            // 
            // btnborrar
            // 
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnborrar.IconColor = System.Drawing.Color.Black;
            this.btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnborrar.IconSize = 20;
            this.btnborrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnborrar.Location = new System.Drawing.Point(307, 15);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(37, 23);
            this.btnborrar.TabIndex = 59;
            this.btnborrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click_1);
            // 
            // rbdocumentocliente
            // 
            this.rbdocumentocliente.AutoSize = true;
            this.rbdocumentocliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbdocumentocliente.Location = new System.Drawing.Point(14, 18);
            this.rbdocumentocliente.Name = "rbdocumentocliente";
            this.rbdocumentocliente.Size = new System.Drawing.Size(118, 17);
            this.rbdocumentocliente.TabIndex = 12;
            this.rbdocumentocliente.Text = "Documento Cliente:";
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
            this.btnbuscar.Location = new System.Drawing.Point(259, 15);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(37, 23);
            this.btnbuscar.TabIndex = 10;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(740, 52);
            this.label2.TabIndex = 88;
            this.label2.Text = "Ingresar Ahorro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 416);
            this.label1.TabIndex = 87;
            // 
            // frmAhorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 488);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.txtidprestamo);
            this.Controls.Add(this.btnAhorrar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAhorro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAhorro";
            this.Load += new System.EventHandler(this.frmAhorro_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnvolver;
        private System.Windows.Forms.TextBox txtidprestamo;
        private FontAwesome.Sharp.IconButton btnAhorrar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtimportepagar;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtfechalimite;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtcuotapagar;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtclientedireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtclientecorreo;
        private System.Windows.Forms.TextBox txtclienteciudad;
        private System.Windows.Forms.TextBox txtclientetelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtclientedocumento;
        private System.Windows.Forms.TextBox txtclientetipodocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtclientenombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnrodocumento;
        private System.Windows.Forms.Label lblestado;
        private FontAwesome.Sharp.IconButton btnborrar;
        private System.Windows.Forms.RadioButton rbdocumentocliente;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbotipomoneda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmontoprestamo;
    }
}