using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldSending : MonoBehaviour
{
    class LoggingIn
    {
        string username;
        string password;

        public LoggingIn(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }

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
        }

    }

    void Update()
    {

    }
}
