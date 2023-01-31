using System;
using System.Collections.Generic;
using UnityEngine;
using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using TMPro;

public class Signup : MonoBehaviour
{
    public TMP_InputField clientidField;
    public TMP_InputField usernameField;
    public TMP_InputField passwordField;

    public void OnClick()
    {
        var client = new AmazonCognitoIdentityProviderClient(null, Amazon.RegionEndpoint.APNortheast1);
        var signup_request = new SignUpRequest //タイポしてた
        {
            ClientId = clientidField.text,
            Username = usernameField.text,
            Password = passwordField.text,
        };

        try
        {
            var result = client.SignUp(signup_request);
            Debug.Log(result);
        }
        catch (Exception ex)
        {
            Debug.LogError(ex);
        }
    }

}
