using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedColor2 : MonoBehaviour
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
    public GameObject Box;
    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.CompareTag("Player")) {
            notife.SetActive(true);
            notifeAnimator.SetBool("getRed",true);
            Box.GetComponent<Rigidbody2D>().mass = 10;
            Destroy(gameObject);
            Destroy(notife,1f);
        }
    }
}
