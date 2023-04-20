using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scenetimer : MonoBehaviour
{
    public float totalTime = 30f;
    private float currentTime;
    
    public string GameOver;

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            currentTime = 0;
            EndTimer();
        }
        
    }

    void EndTimer()
    {
        SceneManager.LoadScene(GameOver); // Load the next scene.
    }
}

