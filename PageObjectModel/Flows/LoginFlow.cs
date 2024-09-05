using Microsoft.Playwright;
using PageObjectModel.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Flows
{
    public class LoginFlow
    {
        public LoginPage page;
        public LoginFlow(LoginPage _page)
        {
            page = _page;
        }

        private string url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
        private string username = "Admin";
        private string password = "admin123";
        
        public async void NavigateToApplication()
        {
            await page.page.GotoAsync(url);
        }
        public async Task LoginWithValidUserAsync()
        {
            page.UserName.FillAsync(username);
            page.Password.FillAsync(password);
            await page.LoginButton.ClickAsync();
        }
    }
}
