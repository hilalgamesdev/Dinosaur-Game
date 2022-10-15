using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public float jumpingforce;
    private Rigidbody2D rb;
    bool jump;
    public GameManager gameManager;
    public GameObject up, down;
    bool doit = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(jump == true)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = jumpingforce * Vector3.up;
                jump = false;
            }
        }
        if (doit == true)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                up.SetActive(false);
                down.SetActive(true);
            }
            else
            {
                up.SetActive(true);
                down.SetActive(false);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
            jump = true;
        }
        if (collision.collider.tag == "obstacle")
        {
            gameManager.GameOver();
            doit = false;
        }
    }
}
