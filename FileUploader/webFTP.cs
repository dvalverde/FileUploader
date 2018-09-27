using System;
using System.Net;
using System.IO;

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
    }
}
