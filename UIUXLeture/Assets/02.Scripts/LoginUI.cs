using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ButtonSoundType
{
    One,
    Two,
    Three
}
public class LoginUI : MonoBehaviour
{
    public List<int> haha = new List<int>();

    public Stack<GameObject> hehe = new Stack<GameObject>();
    public Queue<GameObject> hoho = new Queue<GameObject>();
    /*
     UIUX상 가장 많이 쓰이는 알고리즘(기능
    1.뒤로가기
    2.다음페이지 이동
    3.사운드 출력

    4. 회원가입 시 이메일 구조 체크
    5.회원가입 시 아이디 구조(글자수) 체크 + 비밀번호
     */

    //로그인에 관련된 내용만 작성

    //서버 + 인증 + 오타 + 최대/최소글자제한 + 동의 +....

    public void OnClick_Login()
    {
        Debug.Log("로그인 성공!");
        Login();
        Login_Server();
        Login_Database();
    }
    //UI쪽은 버튼-> 기획따라, 개발 진척도 따라 변화무쌍
    public void ReturnPage()
    {

    }
    public void NextPage()
    {

    }
    public void Login()
    {

    }
    public void Login_Server()
    {

    }
    public void Login_Database()
    {

    }
    UITest uiui;
    public void OnClick_GoToRegist()
    {
        gameObject.SetActive(false);
        GameObject registUI = new GameObject();
        registUI.SetActive(true);

        uiui.OpenPage(registUI);
    }
}
