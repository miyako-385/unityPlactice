using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpforce = 780.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    float threshold = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //ジャンプする
        if(Input.GetMouseButtonDown(0) &&
            this.rigid2D.velocity.y == 0) {
                this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * this.jumpforce);
        }

        //左右移動
        int key = 0;
        if(Input.acceleration.x > this.threshold) key = 1;
        if(Input.acceleration.x < -this.threshold) key = -1;

        //プレイヤの速度（x軸方向の速度の絶対値を拾ってる）
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        //スピード制限（設定した数値に達するまでAddForceを適用する）
        if (speedx < this.maxWalkSpeed) {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        //動く方向に応じて反転
        if(key != 0) {
            transform.localScale = new Vector3(key, 1, 1);
        }

        //プレイヤの速度に応じてアニメーション速度を変える
        if(this.rigid2D.velocity.y == 0) {
            this.animator.speed = speedx / 2.0f;
        } else {
            this.animator.speed = 1.0f;
        }
        

        if(transform.position.y < -10) {
            SceneManager.LoadScene("GameScene");
        }
    }
    //ゴールに到達
        void OnTriggerEnter2D(Collider2D other) {
            Debug.Log("ゴール");
            SceneManager.LoadScene("ClearScene");
        }
}
