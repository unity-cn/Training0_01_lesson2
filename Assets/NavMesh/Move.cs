using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    public Transform goal;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<NavMeshAgent>().destination = goal.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
