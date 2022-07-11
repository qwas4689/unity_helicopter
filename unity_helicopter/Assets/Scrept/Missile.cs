using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour

{
    public bool fire { get; private set; }
    public bool reload { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        fire = false;
        reload = false;
    }

    // Update is called once per frame
    void Update()
    {
        fire = Input.GetKeyDown(KeyCode.F);
        reload = Input.GetKeyDown(KeyCode.R);
    }
}
