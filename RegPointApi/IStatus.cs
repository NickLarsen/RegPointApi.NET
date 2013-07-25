using System.Runtime.InteropServices;

namespace RegPointApi
{
    [ComVisible(false)]
    public interface IStatus
    {
        string status { get; }
    }
}
