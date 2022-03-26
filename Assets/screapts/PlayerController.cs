using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Transform player;
    public float rotationspeed = 10.0f;
    public float speed = 5f;
    Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject.GetComponent<Transform>();
        playerAnim = this.gameObject.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame 
    void Update()
    {
        player.Rotate(Vector3.up,Input.GetAxis("Horizontal") * rotationspeed * Time.deltaTime);
        Vector3 playerDirection = player.forward.normalized;
        playerAnim.SetFloat("PlayerMove", Input.GetAxis("Vertical"));
        player.Translate(playerDirection * speed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
    }
    private void OnCollisionEnter(Collision collision)
    
    {
        if(collision.gameObject.tag=="Enemy")
        {
            SceneManager.LoadScene(0);
        }
    }
}
