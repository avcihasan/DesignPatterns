namespace DesignPatterns.Adapter.Services
{
    public interface IImageService
    {
        void AddWatermark(string text,string filename,Stream imageStream);
    }
}
