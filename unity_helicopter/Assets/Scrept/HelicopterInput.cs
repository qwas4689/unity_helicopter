using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterInput : MonoBehaviour
{
    public bool up { get; private set; }
    public bool down { get; private set; }
    public bool right { get; private set; }
    public bool left { get; private set; }

    public bool go { get; private set; }
    public bool go_back { get; private set; }


    // Start is called before the first frame update
    void Start()
    {
        up = false;
        down = false;
        right = false;
        left = false;

        go = false;
        go_back = false;
    }

    // Update is called once per frame
    void Update()
    {
        up = Input.GetKeyDown(KeyCode.UpArrow);
        down = Input.GetKeyDown(KeyCode.DownArrow);
        right = Input.GetKey(KeyCode.RightArrow);
        left = Input.GetKey(KeyCode.LeftArrow);

        go = Input.GetKey(KeyCode.W);
        go_back = Input.GetKey(KeyCode.S);
    }
}

