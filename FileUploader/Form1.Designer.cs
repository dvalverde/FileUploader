namespace FileUploader
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BorrarBTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxServer = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UlrTB = new System.Windows.Forms.TextBox();
            this.LabelEstado = new System.Windows.Forms.Label();
            this.CargarBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Envio = new System.Windows.Forms.GroupBox();
            this.EnviarBTN = new System.Windows.Forms.Button();
            this.SeleccionTB = new System.Windows.Forms.TextBox();
            this.SeleccionarBTN = new System.Windows.Forms.Button();
            this.ArchivoPanel = new System.Windows.Forms.GroupBox();
            this.TraducirBTN = new System.Windows.Forms.Button();
            this.OrigenTB = new System.Windows.Forms.TextBox();
            this.DestinoTB = new System.Windows.Forms.TextBox();
            this.DestinoBTN = new System.Windows.Forms.Button();
            this.OrigenBTN = new System.Windows.Forms.Button();
            this.TaduccionPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.EliminarBTN = new System.Windows.Forms.Button();
            this.EstadoL = new System.Windows.Forms.Label();
            this.CorregirBTN = new System.Windows.Forms.Button();
            this.ElementoL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EstadoCorL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorTB = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OPENFTP = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Envio.SuspendLayout();
            this.ArchivoPanel.SuspendLayout();
            this.TaduccionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.46983F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.53017F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Envio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ArchivoPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TaduccionPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BorrarBTN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.listBoxServer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.UlrTB);
            this.panel1.Controls.Add(this.LabelEstado);
            this.panel1.Controls.Add(this.CargarBTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(213, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 219);
            this.panel1.TabIndex = 4;
            // 
            // BorrarBTN
            // 
            this.BorrarBTN.Location = new System.Drawing.Point(28, 181);
            this.BorrarBTN.Name = "BorrarBTN";
            this.BorrarBTN.Size = new System.Drawing.Size(182, 23);
            this.BorrarBTN.TabIndex = 13;
            this.BorrarBTN.Text = "Borrar Archivo";
            this.BorrarBTN.UseVisualStyleBackColor = true;
            this.BorrarBTN.Click += new System.EventHandler(this.BorrarBTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Conexion:";
            // 
            // listBoxServer
            // 
            this.listBoxServer.FormattingEnabled = true;
            this.listBoxServer.Items.AddRange(new object[] {
            "MSSQL server",
            "MySQL"});
            this.listBoxServer.Location = new System.Drawing.Point(77, 35);
            this.listBoxServer.Name = "listBoxServer";
            this.listBoxServer.Size = new System.Drawing.Size(130, 30);
            this.listBoxServer.TabIndex = 11;
            this.listBoxServer.SelectedIndexChanged += new System.EventHandler(this.listBoxServer_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ulr de carga";
            // 
            // UlrTB
            // 
            this.UlrTB.Location = new System.Drawing.Point(28, 118);
            this.UlrTB.Name = "UlrTB";
            this.UlrTB.Size = new System.Drawing.Size(179, 20);
            this.UlrTB.TabIndex = 9;
            this.UlrTB.TextChanged += new System.EventHandler(this.UlrTB_TextChanged);
            // 
            // LabelEstado
            // 
            this.LabelEstado.AutoSize = true;
            this.LabelEstado.Location = new System.Drawing.Point(88, 71);
            this.LabelEstado.Name = "LabelEstado";
            this.LabelEstado.Size = new System.Drawing.Size(48, 13);
            this.LabelEstado.TabIndex = 8;
            this.LabelEstado.Text = " ninguna";
            // 
            // CargarBTN
            // 
            this.CargarBTN.Enabled = false;
            this.CargarBTN.Location = new System.Drawing.Point(28, 152);
            this.CargarBTN.Name = "CargarBTN";
            this.CargarBTN.Size = new System.Drawing.Size(182, 23);
            this.CargarBTN.TabIndex = 6;
            this.CargarBTN.Text = "Cargar a base";
            this.CargarBTN.UseVisualStyleBackColor = true;
            this.CargarBTN.Click += new System.EventHandler(this.CargarBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor";
            // 
            // Envio
            // 
            this.Envio.Controls.Add(this.EnviarBTN);
            this.Envio.Controls.Add(this.SeleccionTB);
            this.Envio.Controls.Add(this.SeleccionarBTN);
            this.Envio.Location = new System.Drawing.Point(213, 3);
            this.Envio.Name = "Envio";
            this.Envio.Size = new System.Drawing.Size(236, 219);
            this.Envio.TabIndex = 1;
            this.Envio.TabStop = false;
            this.Envio.Text = "Envio";
            // 
            // EnviarBTN
            // 
            this.EnviarBTN.Enabled = false;
            this.EnviarBTN.Location = new System.Drawing.Point(25, 82);
            this.EnviarBTN.Name = "EnviarBTN";
            this.EnviarBTN.Size = new System.Drawing.Size(179, 23);
            this.EnviarBTN.TabIndex = 7;
            this.EnviarBTN.Text = "Enviar FTP";
            this.EnviarBTN.UseVisualStyleBackColor = true;
            this.EnviarBTN.Click += new System.EventHandler(this.EnviarBTN_Click);
            // 
            // SeleccionTB
            // 
            this.SeleccionTB.Location = new System.Drawing.Point(25, 56);
            this.SeleccionTB.Name = "SeleccionTB";
            this.SeleccionTB.Size = new System.Drawing.Size(179, 20);
            this.SeleccionTB.TabIndex = 6;
            this.SeleccionTB.TextChanged += new System.EventHandler(this.SeleccionTB_TextChanged);
            // 
            // SeleccionarBTN
            // 
            this.SeleccionarBTN.Location = new System.Drawing.Point(25, 23);
            this.SeleccionarBTN.Name = "SeleccionarBTN";
            this.SeleccionarBTN.Size = new System.Drawing.Size(179, 27);
            this.SeleccionarBTN.TabIndex = 5;
            this.SeleccionarBTN.Text = "Seleccionar archivo";
            this.SeleccionarBTN.UseVisualStyleBackColor = true;
            this.SeleccionarBTN.Click += new System.EventHandler(this.SeleccionarBTN_Click);
            // 
            // ArchivoPanel
            // 
            this.ArchivoPanel.Controls.Add(this.TraducirBTN);
            this.ArchivoPanel.Controls.Add(this.OrigenTB);
            this.ArchivoPanel.Controls.Add(this.DestinoTB);
            this.ArchivoPanel.Controls.Add(this.DestinoBTN);
            this.ArchivoPanel.Controls.Add(this.OrigenBTN);
            this.ArchivoPanel.Location = new System.Drawing.Point(3, 3);
            this.ArchivoPanel.Name = "ArchivoPanel";
            this.ArchivoPanel.Size = new System.Drawing.Size(204, 219);
            this.ArchivoPanel.TabIndex = 2;
            this.ArchivoPanel.TabStop = false;
            this.ArchivoPanel.Text = "Archivo";
            // 
            // TraducirBTN
            // 
            this.TraducirBTN.Enabled = false;
            this.TraducirBTN.Location = new System.Drawing.Point(25, 170);
            this.TraducirBTN.Name = "TraducirBTN";
            this.TraducirBTN.Size = new System.Drawing.Size(151, 23);
            this.TraducirBTN.TabIndex = 5;
            this.TraducirBTN.Text = "Traducir a XML";
            this.TraducirBTN.UseVisualStyleBackColor = true;
            this.TraducirBTN.Click += new System.EventHandler(this.TraducirBTN_Click);
            // 
            // OrigenTB
            // 
            this.OrigenTB.Location = new System.Drawing.Point(25, 56);
            this.OrigenTB.Name = "OrigenTB";
            this.OrigenTB.Size = new System.Drawing.Size(151, 20);
            this.OrigenTB.TabIndex = 4;
            this.OrigenTB.TextChanged += new System.EventHandler(this.OrigenTB_TextChanged);
            // 
            // DestinoTB
            // 
            this.DestinoTB.Location = new System.Drawing.Point(25, 126);
            this.DestinoTB.Name = "DestinoTB";
            this.DestinoTB.Size = new System.Drawing.Size(151, 20);
            this.DestinoTB.TabIndex = 3;
            this.DestinoTB.TextChanged += new System.EventHandler(this.DestinoTB_TextChanged);
            // 
            // DestinoBTN
            // 
            this.DestinoBTN.Location = new System.Drawing.Point(25, 93);
            this.DestinoBTN.Name = "DestinoBTN";
            this.DestinoBTN.Size = new System.Drawing.Size(64, 27);
            this.DestinoBTN.TabIndex = 1;
            this.DestinoBTN.Text = "Destino";
            this.DestinoBTN.UseVisualStyleBackColor = true;
            this.DestinoBTN.Click += new System.EventHandler(this.DestinoBTN_Click);
            // 
            // OrigenBTN
            // 
            this.OrigenBTN.Location = new System.Drawing.Point(25, 23);
            this.OrigenBTN.Name = "OrigenBTN";
            this.OrigenBTN.Size = new System.Drawing.Size(64, 27);
            this.OrigenBTN.TabIndex = 0;
            this.OrigenBTN.Text = "Origen";
            this.OrigenBTN.UseVisualStyleBackColor = true;
            this.OrigenBTN.Click += new System.EventHandler(this.OrigenBTN_Click);
            // 
            // TaduccionPanel
            // 
            this.TaduccionPanel.Controls.Add(this.checkBox1);
            this.TaduccionPanel.Controls.Add(this.EliminarBTN);
            this.TaduccionPanel.Controls.Add(this.EstadoL);
            this.TaduccionPanel.Controls.Add(this.CorregirBTN);
            this.TaduccionPanel.Controls.Add(this.ElementoL);
            this.TaduccionPanel.Controls.Add(this.label4);
            this.TaduccionPanel.Controls.Add(this.EstadoCorL);
            this.TaduccionPanel.Controls.Add(this.label3);
            this.TaduccionPanel.Controls.Add(this.label2);
            this.TaduccionPanel.Controls.Add(this.ErrorTB);
            this.TaduccionPanel.Location = new System.Drawing.Point(3, 228);
            this.TaduccionPanel.Name = "TaduccionPanel";
            this.TaduccionPanel.Size = new System.Drawing.Size(204, 219);
            this.TaduccionPanel.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 172);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Eliminar errores";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // EliminarBTN
            // 
            this.EliminarBTN.Enabled = false;
            this.EliminarBTN.Location = new System.Drawing.Point(25, 143);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(151, 23);
            this.EliminarBTN.TabIndex = 8;
            this.EliminarBTN.Text = "Eliminar tupla";
            this.EliminarBTN.UseVisualStyleBackColor = true;
            this.EliminarBTN.Click += new System.EventHandler(this.EliminarBTN_Click);
            // 
            // EstadoL
            // 
            this.EstadoL.AutoSize = true;
            this.EstadoL.Location = new System.Drawing.Point(87, 168);
            this.EstadoL.Name = "EstadoL";
            this.EstadoL.Size = new System.Drawing.Size(10, 13);
            this.EstadoL.TabIndex = 7;
            this.EstadoL.Text = " ";
            // 
            // CorregirBTN
            // 
            this.CorregirBTN.Enabled = false;
            this.CorregirBTN.Location = new System.Drawing.Point(25, 114);
            this.CorregirBTN.Name = "CorregirBTN";
            this.CorregirBTN.Size = new System.Drawing.Size(151, 23);
            this.CorregirBTN.TabIndex = 6;
            this.CorregirBTN.Text = "Corregir";
            this.CorregirBTN.UseVisualStyleBackColor = true;
            this.CorregirBTN.Click += new System.EventHandler(this.CorregirBTN_Click);
            // 
            // ElementoL
            // 
            this.ElementoL.AutoSize = true;
            this.ElementoL.Location = new System.Drawing.Point(103, 46);
            this.ElementoL.Name = "ElementoL";
            this.ElementoL.Size = new System.Drawing.Size(0, 13);
            this.ElementoL.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Elemento";
            // 
            // EstadoCorL
            // 
            this.EstadoCorL.AutoSize = true;
            this.EstadoCorL.Location = new System.Drawing.Point(103, 23);
            this.EstadoCorL.Name = "EstadoCorL";
            this.EstadoCorL.Size = new System.Drawing.Size(45, 13);
            this.EstadoCorL.TabIndex = 3;
            this.EstadoCorL.Text = "Inactivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Error";
            // 
            // ErrorTB
            // 
            this.ErrorTB.Location = new System.Drawing.Point(25, 87);
            this.ErrorTB.Name = "ErrorTB";
            this.ErrorTB.Size = new System.Drawing.Size(151, 20);
            this.ErrorTB.TabIndex = 0;
            this.ErrorTB.TextChanged += new System.EventHandler(this.ErrorTB_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "(.txt)|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "(.xml)|*.xml";
            // 
            // OPENFTP
            // 
            this.OPENFTP.DefaultExt = "xml";
            this.OPENFTP.Filter = "(.xml)|*.xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargador de Archivos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Envio.ResumeLayout(false);
            this.Envio.PerformLayout();
            this.ArchivoPanel.ResumeLayout(false);
            this.ArchivoPanel.PerformLayout();
            this.TaduccionPanel.ResumeLayout(false);
            this.TaduccionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox Envio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ArchivoPanel;
        private System.Windows.Forms.Button DestinoBTN;
        private System.Windows.Forms.Button OrigenBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button EnviarBTN;
        private System.Windows.Forms.TextBox SeleccionTB;
        private System.Windows.Forms.Button SeleccionarBTN;
        private System.Windows.Forms.Button TraducirBTN;
        private System.Windows.Forms.TextBox OrigenTB;
        private System.Windows.Forms.TextBox DestinoTB;
        private System.Windows.Forms.OpenFileDialog OPENFTP;
        private System.Windows.Forms.Panel TaduccionPanel;
        private System.Windows.Forms.Label EstadoL;
        private System.Windows.Forms.Button CorregirBTN;
        private System.Windows.Forms.Label ElementoL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ErrorTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CargarBTN;
        private System.Windows.Forms.Label LabelEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UlrTB;
        private System.Windows.Forms.Button EliminarBTN;
        private System.Windows.Forms.ListBox listBoxServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label EstadoCorL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BorrarBTN;
    }
}

