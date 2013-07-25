using System;
using System.Runtime.InteropServices;

namespace RegPointApi
{
    [ComVisible(false)]
    public class Response<TData>
    {
        public bool WasSuccessful { get; set; }
        public Exception Exception { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public TData Data { get; set; }
    }
}
