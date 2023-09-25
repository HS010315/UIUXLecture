using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
    [SerializeField] private Toggle toggle_1;
    [SerializeField] private Toggle toggle_2;
    [SerializeField] private Toggle toggle_all;

    // [component]_[state]_[name]_[+description]
    [Header("Regist Page")]
    [SerializeField] private GameObject registPage;
    [SerializeField] private Button button_registAccept;
    [SerializeField] private TMP_InputField inputField_email;
    [SerializeField] private TMP_InputField inputField_regist_ID;
    [SerializeField] private TMP_InputField inputField_regist_password;
    [SerializeField] private TMP_InputField inputField_regist_passwordCheck;
    [SerializeField] private GameObject popup_registSuccess;


    #region Login

    public void OnClick_ReturnPage()
    {
        PageTracer.ReturnPage();
    }

    public void OnClick_ReturnToMainPage()
    {
        PageTracer.ReturnPage(loginPage);
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

    public void OnClick_AgreeTas()
    {
        OnGotoRegistPage();
    }

    private void OnGotoRegistPage()
    {
        if(!CheckIsToggleAccept())
        {
            Debug.Log("모두 동의하세요");
            return;
        }
        PageTracer.OpenPage(registPage, termsAndServicePage);
    }
    
    public void OnClick_Toggle1()
    {
        //토글 2의 체크 조사
        //만약, 토글 2가 체크 되어 있을 시 , 토글 all 체크

        //토글 해제시, 토글 all 체크 해제
    }

    public void OnClick_Toggle2()
    {
        //토글 1의 체크 조사
        //만약, 토글 1가 체크 되어 있을 시 , 토글 all 체크

        //토글 해제시, 토글 all 체크 해제
    }

    public void OnClick_ToggleAll()
    {
        //토글 1과 2의 체크 조사
        //각 토글 조사 후 체크 표시 안 되어 있을 시 , 체크
        
        //이미 체크되어 있는 상태 이었을시 , 토글 1과 토글 2 모두 체크 해제
    }

    private bool CheckIsToggleAccept()
    {
        if (!toggle_1.isOn || !toggle_2.isOn)
            return false;

        else
            return true;
    }

    #endregion

    #region Regist

    public void OnClick_RegistAccept()
    {
        OnRegistAccept();

        PageTracer.OpenPage(popup_registSuccess, registPage, true);
    }

    private void OnRegistAccept()
    {
        if(!CheckEmailForm())
        {
            Debug.Log("이메일 양식에 맞지 않습니다.");
            return;
        }
        /*if (!CheckEmailForm(inputField_regist_email.text))
        {
            Debug.Log("이메일 오류");
            return;
        }*/
        if (!CheckPasswordForm())
        {
            Debug.Log("비밀번호는 4~12자 이내의 영문과 숫자의 혼합이 이루어져야 합니다.");
            return;
        }
        /*if (!CheckPasswordForm(inputField_regist_password.text, inputField_regist_passwordCheck.text))
        {
            Debug.Log("비밀번호 오류");
            return;
        }*/
        if (!CheckPasswordSame())
        {
            Debug.Log("비밀번호가 일치하지 않습니다.");
            return;
        }

        Debug.Log("회원가입 성공을 축하드립니다. Siuu!");
    }

    //정규식
    //regex

    private bool CheckEmailForm()
    {
        return true; //false

    }
    private bool CheckPasswordForm(/*string _password, string _passwordCheck, GameObject _formError = null, GameObject _confirmError = null*/)
    {
        return true; //false
        /*if(_password != _passwordCheck)
        {
            return false;
        }
        else
        {
            return true;
        }*/
    }


    private bool CheckPasswordSame()
    {
        return true; //false
    }

    #endregion
}
