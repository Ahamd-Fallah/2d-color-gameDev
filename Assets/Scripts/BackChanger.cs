using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BackChanger : MonoBehaviour
{
    public GameObject BackGround_1;
    public GameObject BackGround_2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeBack() {
        BackGround_1.SetActive(false);
        BackGround_2.SetActive(true);
    }
    void OnTriggerEnter2D(Collider2D other) {
        switch (gameObject.name) {
            case "BlueColor":
                GameManager.getBlue = true;
                GameManager.PrintLog();
                break;
            case "GreenColor":
                GameManager.getGreen = true;
                break;
            case "RedColor":
                GameManager.getRed = true;
                break;
            case "YellowColor":
                GameManager.getYellow = true;
                break;
        }
        if(other.CompareTag("Player")) {
            ChangeBack();
            Destroy(gameObject);
        }
    }

}
