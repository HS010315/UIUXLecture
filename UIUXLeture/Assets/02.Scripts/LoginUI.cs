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
     UIUX�� ���� ���� ���̴� �˰���(���
    1.�ڷΰ���
    2.���������� �̵�
    3.���� ���

    4. ȸ������ �� �̸��� ���� üũ
    5.ȸ������ �� ���̵� ����(���ڼ�) üũ + ��й�ȣ
     */

    //�α��ο� ���õ� ���븸 �ۼ�

    //���� + ���� + ��Ÿ + �ִ�/�ּұ������� + ���� +....

    public void OnClick_Login()
    {
        Debug.Log("�α��� ����!");
        Login();
        Login_Server();
        Login_Database();
    }
    //UI���� ��ư-> ��ȹ����, ���� ��ô�� ���� ��ȭ����
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
