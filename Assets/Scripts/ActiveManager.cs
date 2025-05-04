using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Activetor();
    }
    public enum AroColors {getBlue,getGreen,getRed,getYellow};
    public AroColors choiceColor;
    public GameObject gameObjectForActive;
    void Activetor() {
        switch(choiceColor){
            case AroColors.getBlue:
            if(GameManager.getBlue) {
                gameObjectForActive.SetActive(false);
            }
            break;
            case AroColors.getGreen:
            if(GameManager.getGreen) {
                gameObjectForActive.SetActive(false);
            }
            break;
            case AroColors.getRed:
            if(GameManager.getRed) {
                gameObjectForActive.SetActive(false);
            }
            break;
            case AroColors.getYellow:
            if(GameManager.getYellow) {
                gameObjectForActive.SetActive(false);
            }
            break;
        }
    }
}
