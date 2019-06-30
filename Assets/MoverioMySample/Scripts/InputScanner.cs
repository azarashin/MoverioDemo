using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// どのキーを押したらどの列挙子が反応するかを調べる
/// 予備調査用のクラス
/// </summary>
public class InputScanner : MonoBehaviour
{
    [SerializeField]
    Text _text; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetKey(KeyCode.DownArrow)
        // Input.GetKey(KeyCode.UpArrow)
        // Input.GetKey(KeyCode.LeftArrow)
        // Input.GetKey(KeyCode.RightArrow)
        // Input.GetKey(KeyCode.JoystickButton0)
        // Input.GetKey(KeyCode.Joystick2Button0)
        // Input.GetKey(KeyCode.Mouse0)
        // Input.GetMouseButton(0)


        string info = ""; 
        foreach(KeyCode kc in Enum.GetValues(typeof(KeyCode)))
        {
            if(Input.GetKey(kc))
            {
                info += kc.ToString() + "\n"; 
            }
        }

        for (int i=0;i<4;i++)
        {
            if (Input.GetMouseButton(i))
            {
                info += "##mouse##[" + i + "]\n";
            }
        }
        if(info == "")
        {
            _text.text = "---";
        }
        else
        {
            _text.text = info;
        }
    }
}
