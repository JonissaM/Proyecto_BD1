namespace Formulario_Menu
{
    partial class Devoluciones_Por_Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devoluciones_Por_Compras));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblDevolCompras = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblIdCom = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmotivDev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxProdArtDev = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chckbxMalEstado = new System.Windows.Forms.CheckBox();
            this.chckBuenEstado = new System.Windows.Forms.CheckBox();
            this.txtbxCodProd = new System.Windows.Forms.MaskedTextBox();
            this.lblCantida = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecios = new System.Windows.Forms.TextBox();
            this.lblIdDetCompra = new System.Windows.Forms.Label();
            this.chkbxIdDetComp = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarDevComp = new System.Windows.Forms.Button();
            this.btnmoddevComp = new System.Windows.Forms.Button();
            this.btnEliminarDevComp = new System.Windows.Forms.Button();
            this.btnNuevoDevComp = new System.Windows.Forms.Button();
            this.btnBuscarDevComp = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.pictureBox2);
            this.BarraTitulo.Controls.Add(this.lblDevolCompras);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1080, 51);
            this.BarraTitulo.TabIndex = 26;
            // 
            // lblDevolCompras
            // 
            this.lblDevolCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDevolCompras.AutoSize = true;
            this.lblDevolCompras.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolCompras.ForeColor = System.Drawing.Color.White;
            this.lblDevolCompras.Location = new System.Drawing.Point(308, 9);
            this.lblDevolCompras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevolCompras.Name = "lblDevolCompras";
            this.lblDevolCompras.Size = new System.Drawing.Size(464, 25);
            this.lblDevolCompras.TabIndex = 26;
            this.lblDevolCompras.Text = "REGISTRO DEVOLUCIONES POR COMPRAS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Formulario_Menu.Properties.Resources.WhatsApp_Image_2020_06_06_at_12_33_07_PM;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // lblIdCom
            // 
            this.lblIdCom.AutoSize = true;
            this.lblIdCom.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCom.ForeColor = System.Drawing.Color.White;
            this.lblIdCom.Location = new System.Drawing.Point(186, 93);
            this.lblIdCom.Name = "lblIdCom";
            this.lblIdCom.Size = new System.Drawing.Size(106, 20);
            this.lblIdCom.TabIndex = 27;
            this.lblIdCom.Text = "ID_COMPRA:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(298, 93);
            this.txtId.Mask = "9999";
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 20);
            this.txtId.TabIndex = 28;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtId.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "MOTIVO DE DEVOLUCION:\r\n";
            // 
            // txtmotivDev
            // 
            this.txtmotivDev.Location = new System.Drawing.Point(298, 216);
            this.txtmotivDev.Multiline = true;
            this.txtmotivDev.Name = "txtmotivDev";
            this.txtmotivDev.Size = new System.Drawing.Size(300, 79);
            this.txtmotivDev.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(695, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "FECHA:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(774, 202);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(115, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 36);
            this.label2.TabIndex = 43;
            this.label2.Text = "PRODUCTO/ARTICULO\r\n                  A DEVOLVER:\r\n";
            // 
            // cmbxProdArtDev
            // 
            this.cmbxProdArtDev.FormattingEnabled = true;
            this.cmbxProdArtDev.Location = new System.Drawing.Point(298, 169);
            this.cmbxProdArtDev.Name = "cmbxProdArtDev";
            this.cmbxProdArtDev.Size = new System.Drawing.Size(231, 21);
            this.cmbxProdArtDev.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(691, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "ESTADO: \r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(616, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "COD_PRODUCTO:";
            // 
            // chckbxMalEstado
            // 
            this.chckbxMalEstado.AutoSize = true;
            this.chckbxMalEstado.ForeColor = System.Drawing.Color.White;
            this.chckbxMalEstado.Location = new System.Drawing.Point(774, 244);
            this.chckbxMalEstado.Name = "chckbxMalEstado";
            this.chckbxMalEstado.Size = new System.Drawing.Size(79, 17);
            this.chckbxMalEstado.TabIndex = 48;
            this.chckbxMalEstado.Text = "Mal Estado";
            this.chckbxMalEstado.UseVisualStyleBackColor = true;
            // 
            // chckBuenEstado
            // 
            this.chckBuenEstado.AutoSize = true;
            this.chckBuenEstado.ForeColor = System.Drawing.Color.White;
            this.chckBuenEstado.Location = new System.Drawing.Point(860, 245);
            this.chckBuenEstado.Name = "chckBuenEstado";
            this.chckBuenEstado.Size = new System.Drawing.Size(87, 17);
            this.chckBuenEstado.TabIndex = 49;
            this.chckBuenEstado.Text = "Buen Estado";
            this.chckBuenEstado.UseVisualStyleBackColor = true;
            // 
            // txtbxCodProd
            // 
            this.txtbxCodProd.Location = new System.Drawing.Point(774, 93);
            this.txtbxCodProd.Mask = "9999";
            this.txtbxCodProd.Name = "txtbxCodProd";
            this.txtbxCodProd.Size = new System.Drawing.Size(136, 20);
            this.txtbxCodProd.TabIndex = 50;
            this.txtbxCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbxCodProd.ValidatingType = typeof(int);
            // 
            // lblCantida
            // 
            this.lblCantida.AutoSize = true;
            this.lblCantida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantida.ForeColor = System.Drawing.Color.White;
            this.lblCantida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCantida.Location = new System.Drawing.Point(667, 129);
            this.lblCantida.Name = "lblCantida";
            this.lblCantida.Size = new System.Drawing.Size(90, 18);
            this.lblCantida.TabIndex = 51;
            this.lblCantida.Text = "CANTIDAD: \r\n";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(774, 129);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 52;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrecio.Location = new System.Drawing.Point(684, 168);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(73, 18);
            this.lblPrecio.TabIndex = 53;
            this.lblPrecio.Text = "PRECIO: \r\n";
            // 
            // txtPrecios
            // 
            this.txtPrecios.Location = new System.Drawing.Point(774, 169);
            this.txtPrecios.Name = "txtPrecios";
            this.txtPrecios.Size = new System.Drawing.Size(100, 20);
            this.txtPrecios.TabIndex = 54;
            // 
            // lblIdDetCompra
            // 
            this.lblIdDetCompra.AutoSize = true;
            this.lblIdDetCompra.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDetCompra.ForeColor = System.Drawing.Color.White;
            this.lblIdDetCompra.Location = new System.Drawing.Point(162, 127);
            this.lblIdDetCompra.Name = "lblIdDetCompra";
            this.lblIdDetCompra.Size = new System.Drawing.Size(130, 20);
            this.lblIdDetCompra.TabIndex = 55;
            this.lblIdDetCompra.Text = "ID_DETCOMPRA:";
            // 
            // chkbxIdDetComp
            // 
            this.chkbxIdDetComp.Location = new System.Drawing.Point(298, 130);
            this.chkbxIdDetComp.Mask = "9999";
            this.chkbxIdDetComp.Name = "chkbxIdDetComp";
            this.chkbxIdDetComp.Size = new System.Drawing.Size(136, 20);
            this.chkbxIdDetComp.TabIndex = 56;
            this.chkbxIdDetComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chkbxIdDetComp.ValidatingType = typeof(int);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column2,
            this.Column6});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(214, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(639, 185);
            this.dataGridView1.TabIndex = 57;
            // 
            // btnAgregarDevComp
            // 
            this.btnAgregarDevComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarDevComp.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarDevComp.FlatAppearance.BorderSize = 0;
            this.btnAgregarDevComp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarDevComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDevComp.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDevComp.Image")));
            this.btnAgregarDevComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDevComp.Location = new System.Drawing.Point(221, 551);
            this.btnAgregarDevComp.Name = "btnAgregarDevComp";
            this.btnAgregarDevComp.Size = new System.Drawing.Size(204, 31);
            this.btnAgregarDevComp.TabIndex = 64;
            this.btnAgregarDevComp.Text = "AGREGAR";
            this.btnAgregarDevComp.UseVisualStyleBackColor = false;
            // 
            // btnmoddevComp
            // 
            this.btnmoddevComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmoddevComp.BackColor = System.Drawing.Color.SeaGreen;
            this.btnmoddevComp.FlatAppearance.BorderSize = 0;
            this.btnmoddevComp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnmoddevComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmoddevComp.Image = global::Formulario_Menu.Properties.Resources.icons8_documento_correcto_48;
            this.btnmoddevComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmoddevComp.Location = new System.Drawing.Point(431, 551);
            this.btnmoddevComp.Name = "btnmoddevComp";
            this.btnmoddevComp.Size = new System.Drawing.Size(204, 31);
            this.btnmoddevComp.TabIndex = 68;
            this.btnmoddevComp.Text = "MODIFICAR\r\n";
            this.btnmoddevComp.UseVisualStyleBackColor = false;
            // 
            // btnEliminarDevComp
            // 
            this.btnEliminarDevComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarDevComp.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarDevComp.FlatAppearance.BorderSize = 0;
            this.btnEliminarDevComp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminarDevComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDevComp.Image = global::Formulario_Menu.Properties.Resources.icons8_eliminar_48;
            this.btnEliminarDevComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDevComp.Location = new System.Drawing.Point(641, 551);
            this.btnEliminarDevComp.Name = "btnEliminarDevComp";
            this.btnEliminarDevComp.Size = new System.Drawing.Size(204, 31);
            this.btnEliminarDevComp.TabIndex = 69;
            this.btnEliminarDevComp.Text = "ELIMINAR\r\n";
            this.btnEliminarDevComp.UseVisualStyleBackColor = false;
            // 
            // btnNuevoDevComp
            // 
            this.btnNuevoDevComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoDevComp.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNuevoDevComp.FlatAppearance.BorderSize = 0;
            this.btnNuevoDevComp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNuevoDevComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoDevComp.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoDevComp.Image")));
            this.btnNuevoDevComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoDevComp.Location = new System.Drawing.Point(743, 284);
            this.btnNuevoDevComp.Name = "btnNuevoDevComp";
            this.btnNuevoDevComp.Size = new System.Drawing.Size(204, 31);
            this.btnNuevoDevComp.TabIndex = 70;
            this.btnNuevoDevComp.Text = "NUEVO\r\n";
            this.btnNuevoDevComp.UseVisualStyleBackColor = false;
            // 
            // btnBuscarDevComp
            // 
            this.btnBuscarDevComp.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBuscarDevComp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarDevComp.Location = new System.Drawing.Point(637, 284);
            this.btnBuscarDevComp.Name = "btnBuscarDevComp";
            this.btnBuscarDevComp.Size = new System.Drawing.Size(82, 31);
            this.btnBuscarDevComp.TabIndex = 71;
            this.btnBuscarDevComp.Text = "BUSCAR";
            this.btnBuscarDevComp.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.DividerWidth = 2;
            this.Column1.HeaderText = "ID DETALLE COMPRA";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 151;
            // 
            // Column7
            // 
            this.Column7.DividerWidth = 2;
            this.Column7.HeaderText = "MOTIVO DE DEVOLUCION";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 181;
            // 
            // Column3
            // 
            this.Column3.DividerWidth = 2;
            this.Column3.HeaderText = "OBSERVACIONES";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 132;
            // 
            // Column4
            // 
            this.Column4.DividerWidth = 2;
            this.Column4.HeaderText = "PRODUCTO A DEVOLVER";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 175;
            // 
            // Column5
            // 
            this.Column5.DividerWidth = 2;
            this.Column5.HeaderText = "FECHA DEVOLUCION";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 153;
            // 
            // Column2
            // 
            this.Column2.DividerWidth = 2;
            this.Column2.HeaderText = "CANTIDAD";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 95;
            // 
            // Column6
            // 
            this.Column6.DividerWidth = 2;
            this.Column6.HeaderText = "SUBTOTAL";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 90;
            // 
            // Devoluciones_Por_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.btnBuscarDevComp);
            this.Controls.Add(this.btnNuevoDevComp);
            this.Controls.Add(this.btnEliminarDevComp);
            this.Controls.Add(this.btnmoddevComp);
            this.Controls.Add(this.btnAgregarDevComp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chkbxIdDetComp);
            this.Controls.Add(this.lblIdDetCompra);
            this.Controls.Add(this.txtPrecios);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.lblCantida);
            this.Controls.Add(this.txtbxCodProd);
            this.Controls.Add(this.chckBuenEstado);
            this.Controls.Add(this.chckbxMalEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxProdArtDev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmotivDev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIdCom);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Devoluciones_Por_Compras";
            this.Text = "Devoluciones_Por_Compras";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDevolCompras;
        private System.Windows.Forms.Label lblIdCom;
        private System.Windows.Forms.MaskedTextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmotivDev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxProdArtDev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chckbxMalEstado;
        private System.Windows.Forms.CheckBox chckBuenEstado;
        private System.Windows.Forms.MaskedTextBox txtbxCodProd;
        private System.Windows.Forms.Label lblCantida;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecios;
        private System.Windows.Forms.Label lblIdDetCompra;
        private System.Windows.Forms.MaskedTextBox chkbxIdDetComp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregarDevComp;
        private System.Windows.Forms.Button btnmoddevComp;
        private System.Windows.Forms.Button btnEliminarDevComp;
        private System.Windows.Forms.Button btnNuevoDevComp;
        private System.Windows.Forms.Button btnBuscarDevComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}