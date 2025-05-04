using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedColor : MonoBehaviour
{
    public GameObject notife;
    public Animator notifeAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.CompareTag("Player")) {
            notife.SetActive(true);
            notifeAnimator.SetBool("getRed",true);
            GameManager.getRed = true;
            AroController.jumpForce = 10f;
            AroController.moveSpeed = 7f;
            Destroy(gameObject);
            Destroy(notife,1f);
        }
    }
}
