using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeTag : MonoBehaviour
{
    private static int _tagCount;
    private int _myTag;

    private void Awake()
    {
        TakeTag();
    }

    private void TakeTag()
    {
        _tagCount++;
        _myTag = _tagCount;

        if (_tagCount <= PracticeSettings.MaxTagCount)
        {
            Debug.Log($"CubeTag: 내 번호는 {_myTag}이고 지금까지 센 개수는 {_tagCount}");
        }
        else 
        {
            Debug.Log("5를 초과하여 멈춤니다.");
        }
    }
    public static int GetTagCount()
    {
        return _tagCount;
    }
    public static int ResetTagCount()
    {
        _tagCount = 0;
        Debug.Log("초기화");
        return _tagCount;
    }
}
