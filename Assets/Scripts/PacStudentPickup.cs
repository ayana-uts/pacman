using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentPickup : MonoBehaviour
{
    public AudioSource coinPickupSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pellet"))
        {
            coinPickupSound.Play();  // ペレットを食べたときに効果音を再生
            Destroy(other.gameObject);  // ペレットを消す
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
