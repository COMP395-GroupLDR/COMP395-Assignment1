using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{

    private string id;
    private float interarrivalTime;
    private float serviceTime;

    public Customer(string id, float interarrivalTime, float serviceTime)
    {
        this.id = id;
        this.interarrivalTime = interarrivalTime;
        this.serviceTime = serviceTime;
        LogData();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LogData()
    {
        Debug.Log($"Id: {id}| interarrivaltime: {interarrivalTime}| service time:{serviceTime}");
    }
}
