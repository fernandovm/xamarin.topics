using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationRestartApp
{
    public interface IDialogServices
    {
        void CancelNotification();
        void ShowNotification(string title, string content);
    }
}
