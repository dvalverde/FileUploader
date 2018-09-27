using System;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace FileUploader
{
    public class Txt2Xml
    {
        public string origen; //for paths use @" <path> "
        public string destino;
        public int pos_error;
        public bool finalizado;
        private System.IO.StreamReader sr;
        private System.IO.StreamWriter sw;
        private bool actualizar;
        public string correccion;
        string line;


        public Txt2Xml(string archivoOrigen, string archivoDestino)
        {
            origen = archivoOrigen;
            destino = archivoDestino;
            finalizado = true;
            pos_error = 0;
        }

        public Txt2Xml()
        {
            origen = "";
            destino = "";
            finalizado = true;
            pos_error = 0;
        }

        public void setOrigen (string Origen)
        {
            origen = Origen;
        }


        public void setDestino(string Destino)
        {
            destino = Destino;
        }

        public void encabezado()
        {
            finalizado = false;
            sr = new System.IO.StreamReader(origen);
            sw = new System.IO.StreamWriter(destino);
            try
            {
                sw.WriteLine("<? xml version = \"1.0\" encoding = \"UTF-8\" ?>");
                sw.WriteLine("<ROOT>");
            }
            catch(Exception)

        }
        public void cerrar()
        {
            finalizado = true;
            sr.Close();
            sw.WriteLine(@"<\ROOT>");
            sw.Close();
        }

        public bool translateTupla()
        {
            if (!actualizar)
            {
                char[] Sbuffer = new char[120];
                sr.ReadBlock(Sbuffer, 0, Sbuffer.Length);
                string s = new string(Sbuffer);
                line = Regex.Replace(s, @"\n", "");
            }
            string[] linea = line.Split(',');
            if (actualizar)
            {
                linea[pos_error] = correccion;
                actualizar = false;
            }
            if (!verificar(linea))
            {
                return false;
            }
            else
            {
                Trace.WriteLine("entran else");
                sw.WriteLine(" <VOTANTE>");
                Trace.WriteLine("primer llave");
                alistar(linea);
                Trace.WriteLine("lineas listas");
                for (int i = 0; i < 8; i++)
                {
                    Trace.WriteLine("ele prosesado");
                    sw.WriteLine(linea[i]);
                }
                Trace.WriteLine("todo prosesado");
                sw.WriteLine(@" <\VOTANTE>");
                Trace.WriteLine("cerrar llave");
                return true;
            }
        }

        public bool leido()
        {
            return (sr.Peek() < 0);
        }

        public void cambiar(string reemplazo)
        {
            actualizar=true;
            correccion = reemplazo;
        }

        public void saltar()
        {
            char[] Sbuffer = new char[120];
            sr.ReadBlock(Sbuffer, 0, Sbuffer.Length);
        }

        private bool verificar(string[] elementos)
        {
            correccion = elementos[0];
            pos_error = 0;
            if (!(correccion.Length == 9 && esNumero(correccion)))
                return false;
            pos_error = 1;
            correccion = elementos[pos_error];
            if (!(correccion.Length == 6 && esNumero(correccion)))
                return false;
            pos_error = 2;
            correccion = elementos[pos_error];
            if (!(correccion.Length == 1 && esNumero(correccion)))
                return false;
            pos_error = 4;
            correccion = elementos[pos_error];
            if (!(correccion.Length == 5 && esNumero(correccion)))
                return false;
            pos_error = 5;
            correccion = elementos[pos_error];
            if (!esAlfabetico(correccion))
                return false;
            pos_error = 6;
            correccion = elementos[pos_error];
            if (!esAlfabetico(correccion))
                return false;
            pos_error = 7;
            correccion = elementos[pos_error];
            if (!esAlfabetico(correccion))
                return false;
            return true;
        }

        private void alistar(string[] elementos)
        {
            for (int i = 0; i < 8; i++)
            {
                elementos[i] = etiquetar(elementos[i], i);
            }
        }

        private string etiquetar(string elemento, int posicion)
        {
            string resp = elemento;
            switch (posicion)
            {
                case 0:
                    resp = "  <CEDULA>" + elemento + @"<\CEDULA>";
                    break;
                case 1:
                    resp = "  <CODELEC>" + elemento + @"<\CODELEC>";
                    break;
                case 2:
                    resp = "  <SEXO>" + elemento + @"<\SEXO>";
                    break;
                case 3:
                    resp = "  <FECHACADUC>" + elemento + @"<\FECHACADUC>";
                    break;
                case 4:
                    resp = "  <JUNTA>" + elemento + @"<\JUNTA>";
                    break;
                case 5:
                    resp = "  <NOMBRE>" + elemento + @"<\NOMBRE>";
                    break;
                case 6:
                    resp = "  <1APELLIDO>" + elemento + @"<\1APELLIDO>";
                    break;
                case 7:
                    resp = "  <2APELLIDO>" + elemento + @"<\2APELLIDO>";
                    break;
            }
            return resp;
        }
        private bool esNumero(string s)
        {
            return Regex.IsMatch(s, @"^[0-9]+$");
        }
        private bool esAlfabetico(string s)
        {
            return Regex.IsMatch(s, @"^[a-zA-Z\s]+$");
        }
    }
}
