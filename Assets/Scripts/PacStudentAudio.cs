using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentAudio : MonoBehaviour
{
    // Audio Sourceのフィールドを宣言します
    public AudioSource moveSound;       // PacStudentが移動中に再生される効果音
    public AudioSource pelletEatenSound; // ペレットを食べた時の効果音
    public AudioSource wallHitSound;    // 壁にぶつかった時の効果音

    private Rigidbody2D rb;             // PacStudentの移動に使うRigidbody2D
    public float moveSpeed = 5f;        // PacStudentの移動速度

    public Animator animator; // Animatorコンポーネントの参照

   

    void Start()
    {
        // Rigidbody2Dを取得
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // プレイヤーの入力に基づいて移動方向を決定
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

    

        // Animatorのパラメータに入力値を設定
        animator.SetFloat("Horizontal", moveX);
        animator.SetFloat("Vertical", moveY);

        // PacStudentの移動
        Vector2 movement = new Vector2(moveX, moveY).normalized;
        rb.velocity = movement * moveSpeed;

        // PacStudentが移動しているかどうかを確認し、効果音を再生
        if (movement.magnitude > 0)
        {
            if (!moveSound.isPlaying)
            {
                moveSound.Play();
            }
        }
        else
        {
            moveSound.Stop(); // 停止時に移動音を停止
        }
    }

    // 衝突時のイベントハンドラ
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pellet")
        {
            // ペレットを食べた時の効果音を再生
            pelletEatenSound.Play();
            Destroy(collision.gameObject); // ペレットを消去
        }
        else if (collision.gameObject.tag == "Wall")
        {
            // 壁にぶつかった時の効果音を再生
            wallHitSound.Play();
        }
    }
}
