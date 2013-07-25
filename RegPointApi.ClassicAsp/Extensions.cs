using System;

namespace RegPointApi.ClassicAsp
{
    static class Extensions
    {
        public static string GetMessage(this Exception exception)
        {
            return exception == null ? null : exception.Message;
        }
    }
}
