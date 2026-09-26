using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeScore : MonoBehaviour
{
    private int _point;
    public static PracticeScore Instance { get; private set; }

    public int Point => _point;

    private void Awake()
    {
        SetSingleton();
    }

    private void SetSingleton()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void AddPoint(int point)
    {
        _point += point;

        Debug.Log($"PracticeScore: 점수가 {_point}가 되었습니다.");
    }
}
