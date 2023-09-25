using System;
using System.Collections.Generic;
using UnityEngine;
public static class PageTracer
{
    public static Stack<GameObject> stackedPage = new Stack<GameObject>();

    //매개변수의 기초값이 있으면 넣을지 안넣을진 선택
    public static void OpenPage(GameObject _nextPage, GameObject _prePage, bool _isOpenOnly = false, Action _action = null)
    {
        if (stackedPage.Count < 1)
            stackedPage.Push(_prePage);

        stackedPage.Push(_nextPage);
        _nextPage.SetActive(true);

        if (!_isOpenOnly)
            _prePage.SetActive(false);

        _action?.Invoke();
    }
    public static void ReturnPage(Action _action = null)
    {
        if (stackedPage.Count < 2)
        {
            return;
        }
        stackedPage.Peek().SetActive(false);
        stackedPage.Pop();
        stackedPage.Peek().SetActive(true);
        _action?.Invoke();
    }
    public static void ReturnPage(GameObject _nameOfReturnTo, Action _action = null)
    {
        if (stackedPage.Count < 2)
        {
            return;
        }
        _action?.Invoke();      //_action이 Null값이 아닐시(null값이면 실행안됨 if문의 !=null과 같음
        int targetIndex = -1;
        int currentIndex = 0;
        foreach (GameObject item in stackedPage)
        {
            if (item == _nameOfReturnTo)
            {
                targetIndex = currentIndex;
                break;
            }
            currentIndex++;
        }

        int realTargetIndex = stackedPage.Count - targetIndex;
        while (stackedPage.Count > realTargetIndex)
        {
            stackedPage.Peek().SetActive(false);
            stackedPage.Pop();
        }

        stackedPage.Peek().SetActive(true);
    }
    public static void FlushStackedPages(Action _action = null)
    {
        _action?.Invoke();      //_action이 Null값이 아닐시(null값이면 실행안됨 if문의 !=null과 같음
    }
}
