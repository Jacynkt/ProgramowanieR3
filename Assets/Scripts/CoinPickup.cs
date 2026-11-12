using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    void OnTriggerEnter2D()  //Plays Sound Whenever collision detected
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        Destroy(gameObject);
        Debug.Log("coin collected!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
