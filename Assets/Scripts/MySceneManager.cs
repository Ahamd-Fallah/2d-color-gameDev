using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public bool exitWay;
    public String sceneName;
    public enum Colors {
        Blue,Green,Red,Yellow
    }; 
    public Colors colorType;
    void Start()
    {
        
    }

    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")) 
            switch (colorType)
            {
                case Colors.Blue:
                    if(GameManager.getBlue == false || exitWay) {
                        print("Loading Scene Blue");
                        SceneLoader(sceneName);
                    }
                    break;
                case Colors.Green:
                    if(GameManager.getGreen == false || exitWay) {
                        SceneLoader(sceneName);
                    }
                    break;
                case Colors.Red:
                    if(GameManager.getRed == false || exitWay) {
                        SceneLoader(sceneName);
                    }
                    break;
                case Colors.Yellow:
                    if(GameManager.getYellow == false || exitWay) {
                        SceneLoader(sceneName);
                    }
                    break;
            }
        }

    void SceneLoader(string SceneName) {
        SceneManager.LoadScene(SceneName);
    }
    
}
