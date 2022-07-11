using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMove : MonoBehaviour
{
    private Missile missile;

    private float power = 0.001f;
    private bool[] missileOn = new bool[4] { false, false, false, false };
    private bool a = false;
    private int i = 0;

    private void Awake()
    {
        missile = GetComponent<Missile>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (missile.fire)
        {
            missileOn[i] = true;
            ++i;
            Debug.Log($"{missileOn[0]} , {missileOn[1]}, {missileOn[2]}, {missileOn[3]}");
        }

        if (missileOn[i])
        {
            transform.Translate(power, 0, 0);
            power += 0.001f;
            Debug.Log("1번 미사일 발사");
        }
        
    }
}
