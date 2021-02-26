using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldSending : MonoBehaviour
{

    public InputField UsernameField;
    public InputField PasswordField;

    public void onClick()
    {
        Debug.Log("Sent Username == " + UsernameField.text);
        Debug.Log("Sent Password == " + PasswordField.text);

        UsernameField.text = "";
        PasswordField.text = "";
    }

    void Update()
    {

    }
}
