using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    private HelicopterInput _input_hel;
    private PropellerInput _inputPro;
    private Rigidbody _ri;

    private bool on = false;
    public float up_down_speed = 1.0f;
    public float _ABCSpeed = 0f;

    private float turnturn = 0.5f;
    private float slope = 0.01f;
    private float turn_slope = 0.01f;


    private void Up() => _ri.AddForce(0f, up_down_speed, 0f);

    private void Down() => _ri.AddForce(0f, up_down_speed, 0f);

    // Start is called before the first frame update
    void Awake()
    {
        _inputPro = GetComponent<PropellerInput>();
        _input_hel = GetComponent<HelicopterInput>();
        _ri = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // 시동
        if (_inputPro.Starts)
        {
            _ABCSpeed += 0.001f;
            if (_ABCSpeed >= 2.0f)
            {
                Debug.Log("이륙준비 완료");
                on = true;
            }
        }
        else if (_ABCSpeed < 5.0f)
        {
            on = false;
        }
        else
        {
            if (_ABCSpeed > 0f)
            {
                _ABCSpeed -= 0.002f;
            }
            else if (_ABCSpeed == 0)
            {
                transform.position = (new Vector3(0, 0, 0));
            }
        }

        // 이륙 착륙
        if (on)
        {
            if (_input_hel.up)
            {
                if (up_down_speed >= 2.0f)
                {
                    up_down_speed -= 0.1f;
                }
                up_down_speed += 0.1f;
            }
            else if (_input_hel.down && on)
            {
                if (up_down_speed <= 0.0f)
                {
                    up_down_speed += 0.1f;
                }
                up_down_speed -= 0.1f;
                Down();
            }
            Up();

        }

        // 재자리회전
        if (on)
        {
            if (_input_hel.right)
            {
                transform.Rotate(new Vector3(0, turnturn, 0));
            }
            else if (_input_hel.left)
            {
                transform.Rotate(new Vector3(0, -turnturn, 0));
            }
        }

        // 전진 후진
        if (on)
        {
            if (_input_hel.go)
            {
                transform.Translate(slope, 0, 0);
                transform.Rotate(new Vector3(turn_slope, 0, 0));
            }
            else if (_input_hel.go_back)
            {
                transform.Translate(-slope, 0, 0);
                transform.Rotate(new Vector3(-turn_slope, 0, 0));
            }
        }
    }



}
