using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltShooter : MonoBehaviour
{
    [SerializeField] private GameObject _boltPrefab;

    private void Update()
    {
        ReadFireKey();
    }
    private void ReadFireKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bolt = BoltPool.Instance.Take();
            if (bolt == null)
            {
                return;
            }

            bolt.GetComponent<Bolt>().ResetState(transform.position);
        }
    }
}


