using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NowChanger : MonoBehaviour
{
    public GameObject BackGround_1;
    public GameObject BackGround_2;
    public enum Skills {
        getBlue,
        getGreen,
        getRed,
        getYellow,

    }
    public Skills choiceSkill; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(choiceSkill) {
            case Skills.getBlue:
                if(GameManager.getBlue) {
                    ChangeBack();
                }
                break;
            case Skills.getGreen:
                if(GameManager.getGreen) {
                    ChangeBack();
                }
                break;
            case Skills.getRed:
                if(GameManager.getRed) {
                    ChangeBack();
                }
                break;
            case Skills.getYellow:
                if(GameManager.getYellow) {
                    ChangeBack();
                }
                break;
        }
    }
    void ChangeBack() {
        BackGround_1.SetActive(false);
        BackGround_2.SetActive(true);
    }

}
