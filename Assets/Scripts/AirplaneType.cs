using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AirplaneType : MonoBehaviour
{
    public Airplane airplane;
    public Light lightColor;
    public int airplaneNumber;
    // Start is called before the first frame update
    void Start()
    {
        airplaneNumber = airplane.NumberAssignment();
        gameObject.GetComponentInChildren<TextMeshPro>().text = airplaneNumber.ToString();
        gameObject.name = "Airplane" + airplaneNumber.ToString();

    }
    public void changeLights()
    {
        lightColor = gameObject.GetComponentInChildren<Light>();
        if (lightColor.color == Color.red)
        {
            lightColor.color = Color.clear;
        }
        else
        {
            lightColor.color = Color.red;
        }
    }
    
}
