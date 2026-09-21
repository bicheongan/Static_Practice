using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TagReporter : MonoBehaviour
{
    private void Start()
    {
        ReportCount();
    }
    private void Update()
    {
        Reset();
    }
    private void ReportCount()
    {
        Debug.Log($"CubeTag에서 지금까지 센 개수 {CubeTag.GetTagCount()}");
    }

    private void Reset()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            CubeTag.ResetTagCount();
        }
    }
}
