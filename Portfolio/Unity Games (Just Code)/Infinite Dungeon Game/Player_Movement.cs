using System.Collections;
using System.Collections.Generic;
using System.Xml.XPath;
using UnityEditor;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    #region Variables
    private Rigidbody2D rb;
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] private float speed = 0.5f;
    Vector2 move;
    #endregion

    #region Main Functions
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        //Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        faceCursor();
    }

    private void FixedUpdate()
    {
        Movement();
    }
    #endregion

    #region Custom Functions
    private void faceCursor()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        transform.up = direction;
    }

    private void Movement()
    {
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector2 moveClamped = Vector2.ClampMagnitude(move, 1f);
       
            rb.AddForce(Vector2.up * moveClamped.y * speed * Time.fixedDeltaTime);
            rb.AddForce(Vector2.right * moveClamped.x * speed *  Time.fixedDeltaTime);

        //fix movement so its not as clunky
    }
    #endregion
}
