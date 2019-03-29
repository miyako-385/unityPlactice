using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //while文
        // int x = 0;
        // while (x <8){
        //     x = Random.Range (0, 10);
        //     Debug.Log (x);
        // }
        
        //for文
        // for (int i = 0; i < 10; i++) {
        //     Debug.Log (i);
        // }

        //for文reverse
        for (int i = 9; i >= 0; i--) {
            Debug.Log (i);
        }

        Debug.Log ("終了");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
