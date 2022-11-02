using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Plane", menuName = "Airplane")]
public class Airplane : ScriptableObject
{
    public string type;
    public string merk;
    private int number;

    public int NumberAssignment()
    {
        number = GameManager.Instance.AssignAirplaneNumbers();
        return number;
    }
}
