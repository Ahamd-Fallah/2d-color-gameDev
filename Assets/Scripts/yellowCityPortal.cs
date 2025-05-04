using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yellowCityPortal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.CompareTag("Player") && GameManager.getGreen) {
            AroController.moveSpeed = 3f;
            AroController.jumpForce = 7f;
            SceneManager.LoadScene("Level3");
        }
    }
}
