using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoggingIn
{
    private string username;
    private string password;

    public LoggingIn(string username, string password)
    {
        this.username = username;
        this.password = password;
    }
    public string Username
    {
        get
        {
            return this.username;
        }
    }
    public string Password
    {
        get
        {
            return this.password;
        }
    }
}

public class InputFieldSending : MonoBehaviour
{
    

    public InputField UsernameField;
    public InputField PasswordField;

    LoggingIn li;

    public void onClick()
    {
        if(UsernameField.text != "" && PasswordField.text != "")
        {
            li = new LoggingIn(UsernameField.text, PasswordField.text);
            UsernameField.text = "";
            PasswordField.text = "";
            Debug.Log(li.Username + " " + li.Password);
        }


    }

    void Update()
    {

    }
}
