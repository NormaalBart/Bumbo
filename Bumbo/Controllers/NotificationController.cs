using Microsoft.AspNetCore.Mvc;

namespace Bumbo.Controllers
{
    public class NotificationController : Controller
    {

        public void ShowMessage(MessageType messageType, string message)
        {
            TempData["ValidationType"] = messageType switch
            {
                MessageType.Error => "error",
                MessageType.Warning => "warning",
                MessageType.Success => "success"
            };
            TempData["ValidationMessage"] = message;
        }

        public enum MessageType
        {
            Error, Warning, Success
        }
    }
}
