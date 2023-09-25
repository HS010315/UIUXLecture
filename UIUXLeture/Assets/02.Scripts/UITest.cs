using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITest : MonoBehaviour
{
    [Header("Login")]
    public GameObject a;
    public LoginUI loginClass;
    [Header("Regist")]
    public GameObject b;
    public RegistUI registClass;

    public Stack<GameObject> pageTrace = new Stack<GameObject>();
    public void OpenPage(GameObject _input)
    {
        pageTrace.Push(_input);
    }
    [SerializeField] private AudioClip clip;
    public void ReturnPage()
    {
        pageTrace.Pop();
    }
}
