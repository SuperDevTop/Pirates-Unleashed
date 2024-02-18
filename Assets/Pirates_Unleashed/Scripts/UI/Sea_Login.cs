using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sea_Login : MonoBehaviour
{
    [SerializeField] private InputField inputUsernameSignin;
    [SerializeField] private InputField inputPasswordSignin;
    [SerializeField] private Text textAlert;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void LoginBtnClick()
    {
        if(inputUsernameSignin.text != "" && inputPasswordSignin.text != "")
        {
            SceneManager.LoadScene("Main");
        }
        else
        {
            StartCoroutine(DelayToShowAlert("Please fill in correctly"));
        }
    }

    IEnumerator DelayToShowAlert(string alertStr)
    {
        textAlert.text = alertStr;
        textAlert.gameObject.SetActive(true);
        
        yield return new WaitForSeconds(2f);
        textAlert.gameObject.SetActive(false);
    }
}
