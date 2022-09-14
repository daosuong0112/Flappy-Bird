using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour
{
    public GameManager gameManager;
    private float velocity = 1.4f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            birdMove();
    }

    void birdMove()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
