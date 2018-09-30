using System;
using System.Net;
using System.IO;


/*opcion para mantener solo un archivo en el ftp, el cual puede ser descargado por medio de un batch llamado desde un SP*/
namespace FileUploader
{
    public class webFTP
    {
        private string ftpPassword;
        private string ftpUser;
        public string filename;
        public string ulrname; //"ftp://ftp.example.com/remote/path/file.zip"

        public webFTP(string FtpPassword, string FtpUser)
        {
            ftpPassword = FtpPassword;
            ftpUser = FtpUser;
        }
        public string send()
        {
            string resp = "";
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ulrname);
            request.Credentials = new NetworkCredential(ftpUser, ftpPassword);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            using (Stream fileStream = File.OpenRead(filename))
            using (Stream ftpStream = request.GetRequestStream())
            {
                fileStream.CopyTo(ftpStream);
            }
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                resp = ($"Carga finalizada, estado: {response.StatusDescription}");
            }
            return resp;
        }

        public void setFile(string filepath)
        {
            string ulr = "ftp://35.238.137.162/";
            filename = filepath;
            ulrname = ulr + "datos.xml";
        }

        public string DeleteFile(string ulr)
        {
            string resp = "";
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ulr);
                request.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                request.Method = WebRequestMethods.Ftp.DeleteFile;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    resp = ($"Borrado finalizado, estado: {response.StatusDescription}");
                }
                return resp;
            }
            catch (Exception ex)
            {
                resp = ($"Fallo borrado, estado: {ex.Message}");
                return resp;
            }
        }
    }
}
