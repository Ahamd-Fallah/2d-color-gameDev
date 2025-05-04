using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip level1;
    public AudioClip level2;
    public AudioClip level3;
    public static GameManager Instance;
    public static bool getBlue = false;
    public static bool getGreen = false;
    public static bool getRed = false;
    public static bool getYellow = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private string lastScene = "Start";
    void Update()
    {
    Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name != lastScene)
        {
            lastScene = currentScene.name;

            switch (currentScene.name)
            {
                case "Level1":
                    audioSource.PlayOneShot(level1);
                    break;
                case "Level2":
                    audioSource.Stop();
                    audioSource.PlayOneShot(level2);
                    break;
                case "Level3":
                    audioSource.Stop();
                    audioSource.PlayOneShot(level3);
                    break;
            }
    }}
    void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public static void PrintLog() {
        print(getBlue);
    }

    public void LoadLevel(string level) {
        SceneManager.LoadScene(level);
    }

 
}
