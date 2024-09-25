using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentAudio : MonoBehaviour
{
    // 1つのAudioSourceを使う
    public AudioSource audioSource;

    // 複数のAudioClipを登録
    public AudioClip coinPickupSound;  // ペレットを食べたときの音
    public AudioClip gameOverSound;   // ゴーストにぶつかったときの音

    // 衝突イベントで効果音を切り替える
    void OnTriggerEnter(Collider other)
    {
        // ペレットに触れたら
        if (other.CompareTag("Pellet"))
        {
            audioSource.clip = coinPickupSound;  // ペレットの音を設定
            audioSource.Play();  // 効果音を再生
            Destroy(other.gameObject);  // ペレットを削除
        }
        // ゴーストに触れたら
        else if (other.CompareTag("Ghost"))
        {
            audioSource.clip = gameOverSound;  // ゲームオーバーの音を設定
            audioSource.Play();  // 効果音を再生
            // ゲームオーバー処理
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
