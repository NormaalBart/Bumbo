using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.Validations;

/// <summary>
///     File extensions attribute class
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class AllowExtensionsAttribute : ValidationAttribute
{
    #region Public / Protected Properties

    /// <summary>
    ///     Gets or sets extensions property.
    /// </summary>
    public string Extensions { get; set; } = "png,jpg,jpeg,gif";

    #endregion

    #region Is valid method

    /// <summary>
    ///     Is valid method.
    /// </summary>
    /// <param name="value">Value parameter</param>
    /// <returns>Returns - true is specify extension matches.</returns>
    public override bool IsValid(object value)
    {
        // Initialization
        var file = value as IFormFile;
        var isValid = true;

        // Settings.  
        var allowedExtensions = Extensions.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).ToList();

        // Verification.  
        if (file != null)
        {
            // Initialization.  
            var fileName = file.FileName;

            // Settings.  
            isValid = allowedExtensions.Any(y => fileName.EndsWith(y));
        }

        // Info  
        return isValid;
    }

    #endregion
}