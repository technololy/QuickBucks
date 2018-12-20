using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBucks.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Home,
        Loan,
        Liquidate,
        ResetPassword
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
