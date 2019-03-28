using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //if文
        // int a = 9;
        // if (a >= 3 && a <= 7) {
        //     Debug.Log ("3～7の間");
        // }
        // if (a < 3 || a > 7){
        //     Debug.Log ("3～7の間ではない");
        // }

        //switch文
        string menu = "save";

        switch (menu) {
        case "save" :
            Debug.Log ("保存します");
            break;
        case "open" :
            Debug.Log ("開きます");
            break;
        case "print" :
            Debug.Log ("印刷します");
            break;
        default :
            Debug.Log ("一致する機能がありません");
            break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
