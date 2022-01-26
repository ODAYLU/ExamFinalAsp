using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUploadControl
{
    public class uploadfilepo : UploadInterface
    {
        private IHostingEnvironment IH;
        public uploadfilepo(IHostingEnvironment ih)
        {
            IH = ih;
        }
        public async void uploadfilemultiple(List<IFormFile> files)
        {
            // long tottalBytes = files.Sum(f => f.Length);
            foreach (IFormFile item in files)
            {

                var fileName = item.FileName;

                var serverPath = GetpathAndNameFile(fileName);
                await item.CopyToAsync(new FileStream(serverPath, FileMode.Create));

                //string filename = item.FileName.Trim('"');
                //byte[] buffer = new byte[16 * 1024];
                //using (FileStream output = System.IO.File.Create(this.GetpathAndNameFile(filename)))
                //{
                //    using (Stream input = item.OpenReadStream())
                //    {
                //        long totalReadBytes = 0;
                //        int readBytes;
                //        while ((readBytes = input.Read(buffer,0,buffer.Length))>0)
                //        {
                //            await output.WriteAsync(buffer, 0, readBytes);
                //            totalReadBytes += readBytes;
                //        }
                //    }
                //}
            }
        }

        private string GetpathAndNameFile(string filename)
        {
            string path = Path.Combine(this.IH.WebRootPath, "uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return Path.Combine(path, filename);
        }
    }
}
