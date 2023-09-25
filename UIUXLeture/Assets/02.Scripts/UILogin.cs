using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UILogin : MonoBehaviour
{
    [Header("Main Page")]
    [SerializeField] private GameObject loginPage;
    [SerializeField] private Button button_login;
    [SerializeField] private Button button_regist;
    [SerializeField] private TMP_InputField inputField_ID;
    [SerializeField] private TMP_InputField inputField_password;
    private string input_id;
    private string input_password;


    [Header("Terms and Service")]
    [SerializeField] private GameObject termsAndServicePage;

    [Header("Regist Page")]
    [SerializeField] private GameObject registPage;

    #region Login

    public void OnClick_ReturnPage()
    {
        PageTracer.ReturnPage();
    }


    public void OnClick_Login()
    {
        OnLogin();
    }

    public void OnClick_Regist()
    {
        OnGotoTASPage();
    }
    public void OnLogin()
    {
        input_id = inputField_ID.text;
        input_password = inputField_password.text;

        Debug.Log("입력하신 아이디는: " + input_id);
        Debug.Log("입력하신 비밀번호는: " + input_password);
    }
    private void OnGotoTASPage()
    {
        PageTracer.OpenPage(termsAndServicePage, loginPage);
    }

    #endregion

    #region TAS

    #endregion

}
