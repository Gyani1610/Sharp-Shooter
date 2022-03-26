using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollower : MonoBehaviour
{
    // Start is called before the first frame update
      GameObject player;
      Transform playerPos;
      Transform enemyPos;
      public float enemySpeed = 3.0f;
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        playerPos = player.GetComponent<Transform>();
        enemyPos = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyPos.LookAt(playerPos); 
        float distance = Vector3.Distance(playerPos.position, enemyPos.position);
        if(distance>0.5f)
        {enemyPos.position = enemyPos.position + (transform.forward * enemySpeed * Time.deltaTime);
        }

    }
    private void OnCollisionEnter(Collision collision)
    { if (collision.gameObject.tag=="Bullet")
    {    
        Destroy(this.gameObject);
    }
    }
   
}
