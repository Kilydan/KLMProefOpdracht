using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    int randomNumber;
    List<int> AirplaneCount = new List<int>();
    List<int> HangarCount = new List<int>();
    public Movement movement;
    public AirplaneType airplane;
    private void Awake()
    {
        Instance = this;
    }
    public void ChangeLights()
    {
        foreach(int a in AirplaneCount)
        {
            airplane = GameObject.Find("Airplane" + a).GetComponent<AirplaneType>();
            airplane.changeLights();
        }
    }
    public void Park()
    {
        foreach(int a in AirplaneCount)
        {
            movement = GameObject.Find("Airplane" + a).GetComponent<Movement>();
            movement.parkPlanes(a);            
        }
    }
    public int AssignAirplaneNumbers()
    {
        if(AirplaneCount.Count == 0)
        {
            AirplaneCount.Add(1);
        }
        else
        {
            AirplaneCount.Add(AirplaneCount.Last() + 1);
        }
        return AirplaneCount.Last();
    }
    public int AssignHangarNumbers()
    {
        if (HangarCount.Count == 0)
        {
            HangarCount.Add(1);
        }
        else
        {
            HangarCount.Add(HangarCount.Last() + 1);
        }
        return HangarCount.Last();
    }
}
public enum GameState
{
    Parked,
    Flying
}
