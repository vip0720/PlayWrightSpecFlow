using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Pages
{

    public class LoginPage
    {
        public IPage page;
        public LoginPage(IPage _page)
        {
            page = _page;
        }
        public ILocator UserName
        {
            get
            {
                return page.GetByText("Username");
            }
        }

        public ILocator Password
        {
            get
            {
                return page.GetByText("Password");
            }
        }
        public ILocator LoginButton
        {
            get
            {
                return page.GetByLabel("Login");
            }
        }

    }
}
