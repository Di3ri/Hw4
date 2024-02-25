using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace random_movement
{
    public class NPC : MonoBehaviour
{
    [SerializeField]
    Transform Girl;
    
    NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //makes the avatar move randomly
        nav.SetDestination(transform.position + new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)));
            //movement speed
            nav.speed = 3;
    } 
}
}
