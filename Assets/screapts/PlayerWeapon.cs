using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public Transform muzzel;
    Transform playerpos;
    public float BulletForce = 350f;
    void Start()
    {
        playerpos = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        { GameObject bulletInstance = Instantiate(bullet, muzzel.position, Quaternion.identity);
          Vector3 playerDirection = playerpos.forward.normalized;
          bulletInstance.GetComponent<Rigidbody>().AddForce(playerDirection * BulletForce, ForceMode.Impulse);

        }
    }
}
