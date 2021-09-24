using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingAPIXamarin.Services
{
    public interface IAlertService
    {
        Task DisplayAlertAsync(string title, string description);
    }
}
