using System;
using System.Collections.Generic;
using System.Text;

namespace UnicabApp.Services
{
    public interface IToasts
    {
        void LongToast(string message);
        void ShortToast(string message);
    }
}
