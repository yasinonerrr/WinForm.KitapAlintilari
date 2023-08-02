using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.KitapAlintilari
{
    public class DataStore
    {
        public static AppUser AppUser = new AppUser { Id = 1, Username = "Yasin", Password = "Öner" };
        public static List<Book> Books = new List<Book>()
        {
            new Book{ Id =1, Description ="Kitap 1 -- Alıntı "},
            //new Book{ Id =2, Description ="Kitap 2 -- "},

        };
    }

    public class Book
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }

    public class AppUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
    }
}
