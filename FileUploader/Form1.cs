﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FileUploader
{

    public partial class Form1 : Form
    {
        private Txt2Xml Traductor;
        private SqlFtpReq Consultor;
        private webFTP FTPUploader;
        public bool saltar;
        private bool orig;
        private bool dest;
        private bool selServ;
        private bool selUlr;
        private int serverInd;
        public Form1()
        {
            InitializeComponent();
            orig = false;
            dest = false;
            selServ = false;
            selUlr = false;
            serverInd = 0;
            Consultor= new SqlFtpReq();
            Traductor = new Txt2Xml();
            FTPUploader = new webFTP("61|Itt<^UwI$M+E", "bases2p1");
            saltar = checkBox1.Checked; 
        }

        private void traduccion() {
            while (!Traductor.leido() && Traductor.translateTupla())
            {
                EstadoCorL.Text = "Prosesando";
            }
            if (!Traductor.leido())
            {
                EstadoCorL.Text = "Error";
                string resp="";
                switch (Traductor.pos_error)
                {
                    case 0:
                        resp = "CEDULA";
                        break;
                    case 1:
                        resp = "CODELEC";
                        break;
                    case 2:
                        resp = "SEXO";
                        break;
                    case 3:
                        resp = "FECHACADUC";
                        break;
                    case 4:
                        resp = "JUNTA";
                        break;
                    case 5:
                        resp = "NOMBRE";
                        break;
                    case 6:
                        resp = "APELLIDOUNO";
                        break;
                    case 7:
                        resp = "APELLIDODOS";
                        break;
                }
                EliminarBTN.Enabled = true;
                ElementoL.Text = resp;
                ErrorTB.Text = Traductor.correccion;
                if (Traductor.correccion == "")
                    ErrorTB.Text = "E_Campo_Vacio";
            }
            else
            {
                Traductor.cerrar();
                TraducirBTN.Enabled = true;
                EstadoCorL.Text = "Finalizado";
            }
        }

        private void TraducirBTN_Click(object sender, EventArgs e)
        {
            TraducirBTN.Enabled = false;
            EstadoCorL.Text = "Corrigiendo";
            Traductor.LimpiarFiles();
            Traductor.encabezado();
            traduccion();
        }

        private void CorregirBTN_Click(object sender, EventArgs e)
        {
            EstadoCorL.Text = "Corrigiendo";
            ErrorTB.Text = "";
            ElementoL.Text = "";
            CorregirBTN.Enabled = false;
            EliminarBTN.Enabled = false;
            Traductor.cambiar(ErrorTB.Text);
            traduccion();
        }

        private void EliminarBTN_Click(object sender, EventArgs e)
        {
            EstadoCorL.Text = "Tupla Ignorada";
            ErrorTB.Text = "";
            ElementoL.Text = "";
            CorregirBTN.Enabled = false;
            EliminarBTN.Enabled = false;
            Traductor.saltar();
            traduccion();
        }

        private void DestinoBTN_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DestinoTB.Text = saveFileDialog1.FileName;
                Traductor.setDestino(DestinoTB.Text);
                dest = true;
                if (orig && dest)
                    TraducirBTN.Enabled = true;
                else
                    TraducirBTN.Enabled = false;
            }
        }


        private void OrigenBTN_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OrigenTB.Text= openFileDialog1.FileName;
                Traductor.setOrigen(OrigenTB.Text);
                orig = true;
                if (orig && dest)
                    TraducirBTN.Enabled = true;
                else
                    TraducirBTN.Enabled = false;
            }
        }

        private void SeleccionarBTN_Click(object sender, EventArgs e)
        {
            if (OPENFTP.ShowDialog() == DialogResult.OK)
            {
                SeleccionTB.Text = OPENFTP.FileName;
            }
        }

        private void EnviarBTN_Click(object sender, EventArgs e)
        {
            string file = SeleccionTB.Text;
            FTPUploader.setFile(file);
            string ulrOrig = FTPUploader.ulrname;
            string Mensage= FTPUploader.send();
            MessageBox.Show(Mensage);
            UlrTB.Text = ulrOrig;
        }

        private void CargarBTN_Click(object sender, EventArgs e)
        {
            string a= Consultor.sendFtpMSDownload(UlrTB.Text);
            /*if (serverInd == 0)
                Consultor.sendFtpMSDownload(UlrTB.Text);
            else
                Consultor.sendFtpMyDownload(UlrTB.Text);*/
            if (Consultor.Errores)
                MessageBox.Show("Ocurrieron Excepciones durante la carga"+a,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
                MessageBox.Show("Se modificaron "+ Consultor.inserciones+" filas");
        }

        private void OrigenTB_TextChanged(object sender, EventArgs e)
        {
            orig = true;
            Traductor.setOrigen(OrigenTB.Text);
            if (orig && dest)
                TraducirBTN.Enabled = true;
            else
                TraducirBTN.Enabled = false;
        }

        private void DestinoTB_TextChanged(object sender, EventArgs e)
        {
            dest = true;
            Traductor.setDestino(DestinoTB.Text);
            if (orig && dest)
                TraducirBTN.Enabled = true;
            else
                TraducirBTN.Enabled = false;
        }

        private void ErrorTB_TextChanged(object sender, EventArgs e)
        {
            if (saltar)
            {
                Traductor.saltar();
                EstadoCorL.Text = "Tupla Ignorada";
                ErrorTB.Text = "";
                ElementoL.Text = "";
                CorregirBTN.Enabled = false;
                EliminarBTN.Enabled = false;
                if(!Traductor.finalizado)
                    traduccion();
            }
            else
            {
                if (ErrorTB.Text != Traductor.correccion)
                    CorregirBTN.Enabled = true;
            }
        }

        private void SeleccionTB_TextChanged(object sender, EventArgs e)
        {
            EnviarBTN.Enabled = true;
        }


        private void UlrTB_TextChanged(object sender, EventArgs e)
        {
            if (UlrTB.Text != "")
            {
                selUlr = true;
                FTPUploader.ulrname = UlrTB.Text;
            }
            else
            {
                selUlr = false;
            }
            if (selServ && selUlr)
            {
                CargarBTN.Enabled = true;
            }
            else
            {
                CargarBTN.Enabled = false;
            }
        }

        private void listBoxServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            serverInd = listBoxServer.SelectedIndex;
            if (Consultor.IsServerConnected(serverInd))
            {
                selServ = true;
                LabelEstado.Text = "Disponible";
            }
            else
            {
                selServ = false;
                LabelEstado.Text = "No disponible";
            }
            if (selServ && selUlr)
                CargarBTN.Enabled = true;
            else
                CargarBTN.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            saltar = checkBox1.Checked;
        }

        private void BorrarBTN_Click(object sender, EventArgs e)
        {
            string file = UlrTB.Text;
            string Mensage = FTPUploader.DeleteFile(file);
            MessageBox.Show(Mensage);
            UlrTB.Text = "";
        }
    }
}
