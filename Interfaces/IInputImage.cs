using openCV;

namespace ImageProcessor.Interfaces
{
    public interface IInputImage
    {
        IplImage IMAGE1 { get; set; }
        IplImage IMAGE2 { get; set; }
    }
}
