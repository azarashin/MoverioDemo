using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 表示オブジェクト群が正面に来るように調整するためのクラス
/// </summary>
public class OriginController : MonoBehaviour
{
    [SerializeField]
    GameObject _head; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            // 表示オブジェクトの根っこをカメラの向きと同じにする。
            transform.rotation = _head.transform.rotation; 
        }
    }
}
