using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentGameOver : MonoBehaviour
{

    public AudioSource gameOverSound;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ghost"))
        {
            gameOverSound.Play();  // ゴーストにぶつかって死亡したときに効果音を再生
            // ゲームオーバー処理をここに記載
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
