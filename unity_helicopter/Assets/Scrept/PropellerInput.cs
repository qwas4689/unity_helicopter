using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerInput : MonoBehaviour
{
    public float X { get; private set; }
    public float Y { get; private set; }
    public bool Starts { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        X = 0f;
        Y = 0f;
        Starts = false;
    }

    // Update is called once per frame
    void Update()
    {
        X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");
        Starts = Input.GetKey(KeyCode.Space);
    }
}
