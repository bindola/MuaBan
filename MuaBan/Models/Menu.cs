using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuaBan.Models
{
    
        public class MenuLinkInfo
        {
            public string Text { get; set; }
            public string Url { get; set; }
            public bool NewWindow { get; set; }
            public string Target { get { return NewWindow ? "_blank" : null; } }
            public string Titile { get; set; }
            public MenuLinkInfo() { }
            public MenuLinkInfo(string text = null, string url = null, bool newwindow = false, string title = null)
            {
                Text = text;
                Url = url;
                NewWindow = newwindow;
                Titile = title;
            }
        }
        public class MenuList
        {
            public string Text { get; set; }
            public MenuLinkInfo Link { get; set;}
            public List<MenuList> MenuItems { get; set; }
            public bool HasSubMenu { get { return MenuItems != null && MenuItems.Any() && MenuItems.Count > 0; } }
            public MenuList() {}
            public MenuList( MenuLinkInfo link)
            {
                Link = link;
            }

        }
    }
