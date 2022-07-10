using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerMove : MonoBehaviour
{
    private PropellerInput _input;
    private Rigidbody _ri;

    private bool On = false;
    private int _speed = 1;
    public float addSpeed = 0f;

    private void Awake()
    {
        _input = GetComponent<PropellerInput>();
        _ri = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    private void Update()
    {
        // 프로펠러 시동
        if (_input.Starts)
        {
            On = true;
            addSpeed += 0.001f;
            if (On)
            {
                transform.Rotate(new Vector3(0, -_speed * addSpeed, 0));
            }
          
        }
        else
        {
            if (addSpeed > 0f)
            {
                addSpeed -= 0.002f;
                transform.Rotate(new Vector3(0, -_speed * addSpeed, 0));
              
                
            }
            else if (addSpeed == 0)
            {
                transform.Rotate(new Vector3(0, 0, 0));
            }
        }
    }

    
}
