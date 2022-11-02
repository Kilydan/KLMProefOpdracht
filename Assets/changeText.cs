using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class changeText : MonoBehaviour
{
    public TextMeshProUGUI flyStateText, lightStateText;
    
    public void newFlyText()
    {
        if (flyStateText.text == "Park")
        {
            flyStateText.text = "Fly";
        }
        else
        {
            flyStateText.text = "Park";
        }
    }
    public void newLightText()
    {
        if(lightStateText.text == "Lights Off")
        {
            lightStateText.text = "Lights On";
        }
        else
        {
            lightStateText.text = "Lights Off";
        }

    }
}
