using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fighting2d : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb;
    public GameObject player;
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        float moveX = 0;
        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D)))
        moveX = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * speed * moveX * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.E))
        {
            //strike();
            player.GetComponent<Animator>().SetTrigger("Attack");
        }
    }
}
