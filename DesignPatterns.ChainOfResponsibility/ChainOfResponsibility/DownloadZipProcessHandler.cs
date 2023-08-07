using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.ChainOfResponsibility.ChainOfResponsibility
{
    public class DownloadZipProcessHandler : ProcessHandler
    {
        public override object Handler(object o, Type T)
        {
            var zipMemoryStream = o as MemoryStream;
            zipMemoryStream.Position = 0;

            return zipMemoryStream.ToArray();
        }
    }
}
