using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public static MovementController Instance;

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;
    public Vector2 lookDir;
    public float angle;

    public Vector2 movement;
    public Vector2 mousePos;


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        rb = gameObject.GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        lookDir = mousePos - rb.position;
        angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        rb.rotation = angle;
    }



}

