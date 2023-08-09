using System.Drawing;

namespace DesignPatterns.Adapter.Services
{
    public class AdvanceImageServiceAdaptar : IImageService
    {
        readonly IAdvanceImageService _imageService;

        public AdvanceImageServiceAdaptar(IAdvanceImageService imageService)
        {
            _imageService = imageService;
        }

        public void AddWatermark(string text, string filename, Stream imageStream)
        {
            _imageService.AddWatermarkImage(imageStream, text, $"wwwroot/watermarks/{filename}", Color.FromArgb(128, 255, 255, 255), Color.FromArgb(0, 255, 255, 255));
        }
    }
}
