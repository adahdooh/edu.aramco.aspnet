using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace edu.aramco.aspnet.ui.Components.Pages;

public partial class Login()
{
    protected LoginModel login = new();
    protected string? message;
    protected bool? isValidCredentials;
    protected bool isLoading = false;
    [Inject] protected IHttpClientFactory HttpClientFactory { get; set; } = default!;

    private async Task HandleValidSubmit(EditContext context)
    {
        isLoading = true;
        var commingData = context.Model as LoginModel;

        try
        {
            await Task.Delay(300);
            if (context.Validate())
                message = "Validation successful!";

            var client = HttpClientFactory.CreateClient("internalClient");
            var response = await client.PostAsJsonAsync("Users/authenticate", commingData);

            if (response.IsSuccessStatusCode)
            {
                var token = await response.Content.ReadAsStringAsync();

                isValidCredentials = true;
                message = "Login successful!";
            }
            else
            {
                isValidCredentials = false;

                var responseContent = await response.Content.ReadAsStringAsync();
                message = responseContent;
            }


            // if (commingData.Password != "123")
            // {
            //     message = "Invalid password. Please try again.";
            //     isLoading = false;
            //     isValidCredentials = false;
            //     return;
            // }
            // message = "Login successful!";
            // isLoading = false;
            // isValidCredentials = true;
        }
        finally
        {
            isLoading = false;
        }
    }
}

public class LoginModel
{
    [Required(ErrorMessage = "Email is required")]
    // [EmailAddress(ErrorMessage = "Enter a valid email address")]
    public string UserName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Password is required")]
    [MinLength(3, ErrorMessage = "Password must be at least 6 characters")]
    public string Password { get; set; } = string.Empty;

    public bool RememberMe { get; set; }
}
