using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGiver : MonoBehaviour
{
    private const int POINT_PER_PRESS = 10;

    private void Start()
    {
        ReportPoint();
    }
    private void Update()
    {
        ReadPointKey();
    }
    private void ReportPoint()
    {
        Debug.Log(PracticeScore.Instance.Point);
    }
    private void ReadPointKey()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PracticeScore.Instance.AddPoint(POINT_PER_PRESS);
        }
    }
}
