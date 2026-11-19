using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private UI ui;
    void Start()
    {
        ui = FindAnyObjectByType<UI>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(ui.score >= ui.maxScore)
        {
            StartCoroutine(LoadNewScene());
        }
        else
        {
            Debug.Log("not enough coins!");
        }
    }

    private IEnumerator LoadNewScene()
    {
        Debug.Log("next level!");
        ui.Win();

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
