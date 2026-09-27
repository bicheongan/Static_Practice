using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour
{
    [SerializeField] private float _meterPerSecond = 8f;
    [SerializeField] private float _lifeSeconds = 2f;

    private float _elapsed;

    private void Update()
    {
        MoveForward();
        CountLifeTime();
    }
    private void MoveForward()
    {
        transform.position += Vector3.forward *_meterPerSecond * Time.deltaTime;
    }
    private void CountLifeTime()
    {
        _elapsed += Time.deltaTime;
        if(_elapsed >= _lifeSeconds)
        {
            BoltPool.Instance.Return(gameObject);
        }
    }
    public void ResetState(Vector3 start)
    {
        transform.position = start;
        _elapsed = 0f;
    }
}
