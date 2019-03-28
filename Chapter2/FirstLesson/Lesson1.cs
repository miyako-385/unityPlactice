using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Person p = new Person ();//これがインスタンス
        p.firstname = "太郎";
        p.lastname = "山田";
        Debug.Log (p.GetFullName ("★"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class Person{
    public string firstname;
    public string lastname;

    public string GetFullName (string separator) {
        return this.lastname + separator + this.firstname;
    }
}