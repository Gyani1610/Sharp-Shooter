using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    Transform camera;
    Vector3 initialDistance;
    void Start()
    {
        camera = this.gameObject.GetComponent<Transform>();
        initialDistance = player.position - camera.position;
    }

    // Update is called once per frame
    void Update()
    {
        camera.position = player.position - initialDistance;
    }
}
