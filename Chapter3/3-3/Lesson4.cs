using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int型配列
        // int[] arr = {-1, 53, 21, 16, 4};
        // for (int i = 0; i < 5; i++) {
        //     arr [i] = arr [i] * 2;
        //     Debug.Log (arr[i]);
        // }

        //クラス配列1
        // Person[] parr = new Person[5];

        // parr [0] = new Person ();

        // parr [0].firstname = "太郎";
        // parr [0].lastname = "山田";
        // Debug.Log (parr [0].getFullName ("★"));

        //クラス配列2
        // Person[] parr = { new Person (), new Person () };

        // parr [0].firstname = "太郎";
        // parr [0].lastname = "山田";
        // Debug.Log (parr [0].getFullName ("★"));

        //クラス配列3
        Person[] parr = {
            new Person ("太郎", "山田"),
            new Person ("花子", "田中")
        };
        Debug.Log (parr [0].getFullName ("★"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
