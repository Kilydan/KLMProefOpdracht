using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hangar : MonoBehaviour
{
    // Start is called before the first frame update
    public int hangarNumber;
    public bool parked;
    void Start()
    {
        hangarNumber = GameManager.Instance.AssignHangarNumbers();
        gameObject.GetComponentInChildren<TextMeshPro>().text = hangarNumber.ToString();
        gameObject.name = "Hangar" + hangarNumber.ToString();
    }

}
