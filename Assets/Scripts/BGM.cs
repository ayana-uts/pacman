using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioSource bgmGameplay;
    // Start is called before the first frame update
    void Start()
    {
        bgmGameplay.Play();  // ゲーム開始時にBGMを再生
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
