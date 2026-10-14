using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    void OnTriggerEnter2D()  //Plays Sound Whenever collision detected
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
