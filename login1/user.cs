using login1;
using System;
using System.Collections.ObjectModel;

public class User : MainWindow
{
    public string login { get; set; }
    public string password { get; set; }
    public static ObservableCollection<User> GetUsers()
    {
        var userList = new ObservableCollection<User>()
            {
            new User()
            {
                login = "andrei",
                password = "suvorov"
            },
            new User()
            {
                login = "user",
                password = "12345"
            }
        };
        return userList;
    }





}


