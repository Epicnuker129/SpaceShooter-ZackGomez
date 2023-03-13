using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float speed = 2f;
    private bool hit = false;
    
 //   public Transform Playerlocation;
  //  UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
    //    agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.down);
       // agent.destination = Playerlocation.position;
       if (transform.position.y <-100f)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (!hit)
        {
            if (other.gameObject.tag == "Laser")
            {
                hit = true;
                GameObject.Find("PointFix").GetComponent<PointFix>().SetPointo(1);
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
            else if (other.gameObject.tag == "Player")
            {
                other.gameObject.GetComponent<PlayerController>().EnemydamagePlyr();
            }
        }
    }
}