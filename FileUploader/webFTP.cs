using System;
using System.Net;
using System.IO;


/*opcion para mantener solo un archivo en el ftp, el cual puede ser descargado por medio de un batch llamado desde un SP*/
namespace FileUploader
{
    public class webFTP
    {
        string ftpPassword;
        string ftpUser;
        string filename;
        string ulrname; //"ftp://ftp.example.com/remote/path/file.zip"

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

        public void setFile(string filepath, string namefile)
        {
            string ulr = "";
            filename = filepath;
            ulrname = ulr + namefile;
        }

        public bool DeleteFileOnServer(Uri serverUri)
        {
            // The serverUri parameter should use the ftp:// scheme.
            // It contains the name of the server file that is to be deleted.
            // Example: ftp://contoso.com/someFile.txt.
            // 

            if (serverUri.Scheme != Uri.UriSchemeFtp)
            {
                return false;
            }
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serverUri);
            request.Method = WebRequestMethods.Ftp.DeleteFile;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            //Console.WriteLine("Delete status: {0}", response.StatusDescription);
            response.Close();
            return true;
        }
    }
}
