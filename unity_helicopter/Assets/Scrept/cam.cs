using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public GameObject player;

    private Vector3 _distance;
    // Start is called before the first frame update
    void Start()
    {

    }

    void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(-4f, 3f, 0);
    }
}
