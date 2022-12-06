using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class NotificationController : Controller
    {

        public void ShowMessage(MessageType messageType, string message)
        {
            switch (messageType)
            {
                case MessageType.Error:
                    TempData["ValidationType"] = "error";
                    break;
                case MessageType.Warning:
                    TempData["ValidationType"] = "warning";
                    break;
                case MessageType.Success:
                    TempData["ValidationType"] = "success";
                    break;
            }
            TempData["ValidationMessage"] = message;
        }

        public enum MessageType
        {
            Error, Warning, Success
        }
    }
}
