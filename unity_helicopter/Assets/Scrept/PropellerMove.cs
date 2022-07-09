using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerMove : MonoBehaviour
{
    private PropellerInput _input;
    private Rigidbody _ri;
    private bool On = false;
    private int _speed = 1;
    private int addSpeed = 0;

    private void Awake()
    {
        _input = GetComponent<PropellerInput>();
        _ri = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    private void Update()
    {
        if (_input.Starts)
        {
            On = true;
            ++addSpeed;
            if (On)
            {
                transform.Rotate(new Vector3(0, _speed * addSpeed, 0));
            }
            else
            {
                On = false;
                if (On == false)
                {
                    transform.Rotate(new Vector3(0, 0, 0));
                }
            }
        }

        

    }
}
