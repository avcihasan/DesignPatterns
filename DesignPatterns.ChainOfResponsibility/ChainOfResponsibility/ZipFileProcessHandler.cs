using DocumentFormat.OpenXml.Drawing;
using System.IO.Compression;
using System.Reflection;

namespace DesignPatterns.ChainOfResponsibility.ChainOfResponsibility
{
    public class ZipFileProcessHandler : ProcessHandler
    {
        public override object Handler(object o, Type T)
        {

            var excelMemoryStream = o as MemoryStream;

            excelMemoryStream.Position = 0;

            using (var zipStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(zipStream, ZipArchiveMode.Create, true))
                {
                    var zipFile = archive.CreateEntry($"{T.Name}.xlsx");

                    using (var zipEntry = zipFile.Open())
                    {
                        excelMemoryStream.CopyTo(zipEntry);
                    }
                }
                return base.Handler(zipStream, T);
            }
        }
    }
}
