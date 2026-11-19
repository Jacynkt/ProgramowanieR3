using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private Collider2D collider2d;
    [SerializeField] private AudioSource audiosource;
    private UI ui;
    void Start()
    {
        ui = FindAnyObjectByType<UI>();
    }

    void OnTriggerEnter2D()  //Plays Sound Whenever collision detected
    {
        audiosource.Play();
        sprite.enabled = false;
        collider2d.enabled = false;
        ui.score++;
        Debug.Log("coin collected!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
