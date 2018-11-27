using System.Collections;
using UnityEngine;
using UnityEditor;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Rigidbody2D rb;

    private float horizontalMovement;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    void Move()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            rb.AddForce(-transform.right * speed * Time.deltaTime);
            transform.localScale = new Vector3(-1f, 1f, 1f);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {

            rb.AddForce(transform.right * speed * Time.deltaTime);
            transform.localScale = new Vector3(1f, 1f, 1f);

        }

    }

    void FixedUpdate()
    {



        Move();

    }

}
