using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    public GameObject carPrefab;
    GameObject flag;
    GameObject distance;
    public GameObject retryButton;

    // Start is called before the first frame update
    void Start()
    {
        //各オブジェクトを探してくる
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
        //リトライボタン非表示
        this.retryButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //ゴール―車間の距離を算出
        float length = this.flag.transform.position.x - 
            this.car.transform.position.x;
        this.distance.GetComponent<Text>().text = 
            "ゴールまで" + length.ToString("F2") + "m";

        if(length < 0){
           
            //ゲームオーバーテキスト表示
            this.distance.GetComponent<Text>().text = "ゲームオーバー";
            //リトライボタン表示
            this.retryButton.SetActive(true);
           
        }
    }

    //リトライボタン押した
    public void pushRetryButton() {
        //車オブジェクト消える
        Destroy (this.car);
        this.car = (GameObject)Instantiate (carPrefab);
        retryButton.SetActive (false);  //リトライボタンを非表示
    }
}
