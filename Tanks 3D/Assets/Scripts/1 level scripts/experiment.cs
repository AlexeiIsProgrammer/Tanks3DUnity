using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class experiment : MonoBehaviour
{

    public Transform House;
    public Transform MyTank;

    private NavMeshAgent myAgent;
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }

 
    void FixedUpdate()
    {
        if (Vector3.Distance(MyTank.position, transform.position) < 4f)
        {
            myAgent.destination = MyTank.position;
        }
        else
        {
            myAgent.destination = House.position;
        }
            
    }
}
