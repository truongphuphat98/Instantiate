using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePrefab : MonoBehaviour
{
    public GameObject prefab;

    [Header("Prefab Life")]
    float spamLife = .5f;
    int normalLife = 5;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Destroy(Instantiate(prefab.gameObject, new Vector3(), Quaternion.identity), spamLife);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Destroy(Instantiate(prefab.gameObject, new Vector3(), Quaternion.identity), normalLife);
        }

    }
}
