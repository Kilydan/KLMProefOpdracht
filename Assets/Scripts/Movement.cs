using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Movement : MonoBehaviour
{
    public float timer = 4;
    public GameObject Ground = null;
    private NavMeshAgent nma = null;
    Vector3 rpos, hangerPos;

    private bool parked = false;
    private Bounds bounds;

    void Start()
    {
        nma = this.GetComponent<NavMeshAgent>();
        bounds = Ground.GetComponent<Renderer>().bounds;
    }

    // Update is called once per frame
    void Update()
    {
        if ((nma.hasPath == false || nma.remainingDistance < 1.0f) && parked == false)
        {
            Invoke("RandomDestination", timer);
        }
        if(parked == true && nma.remainingDistance < 0.1f)
        {
            GameObject.Find("TMPAirPlaneMode").GetComponent<TextMeshProUGUI>().text = "Status: Parked";
        }
    }
    private void RandomDestination()
    {
        float rx = Random.Range(bounds.min.x, bounds.max.x);
        float rz = Random.Range(bounds.min.z, bounds.max.z);
        rpos = new Vector3(rx, this.transform.position.y, rz);
        nma.SetDestination(rpos);
    }
    public void parkPlanes(int number)
    {
        if (!parked)
        {
            rpos = GameObject.Find("Hangar" + number).transform.position;
            hangerPos = rpos;
            nma.SetDestination(rpos);
            CancelInvoke();
            parked = true;
        }
        else
        {
            Invoke("RandomDestination", 0.0f);
            parked = false;
            GameObject.Find("TMPAirPlaneMode").GetComponent<TextMeshProUGUI>().text = "Status: Flying";
        }
        
    }
}
