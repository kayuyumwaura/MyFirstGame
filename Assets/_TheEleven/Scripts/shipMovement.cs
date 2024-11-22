using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMovement : MonoBehaviour
{
    private const float rightLimit = 8.0f;
    private const float leftLimit = -8.0f;

    private const float upLimit = 3.8f;
    private const float downLimit = -3.8f;

    public float speed;

    public GameManager gameManager;

    //private void Awake()
    //{
    //    Debug.Log("InAwake");
    //}
    //private void OnEnable()
    //{
    //    Debug.Log("InOnEnable");
    //}



    // Update is called once per frame
    void Update()
    {
        Move();
        Contain();




        //if (Input.GetKey(KeyCode.Space))
        //{
        //    Debug.Log("Space Bar Down!");
        //}

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("Space Bar Pressed!");
        //}

        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    Debug.Log("Space Bar Up!");
        //}



    }

    private void Contain()
    {
        if (transform.position.x >= rightLimit)
        {

            transform.position = new Vector2(rightLimit, transform.position.y);
        }
        if (transform.position.x <= leftLimit)
        {
            transform.position = new Vector2(leftLimit, transform.position.y);
        }

        if (transform.position.y >= upLimit)
        {
            transform.position = new Vector2(transform.position.x, upLimit);
        }
        if (transform.position.y <= downLimit)
        {
            transform.position = new Vector2(transform.position.x, downLimit);
        }
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(new Vector2(horizontal, vertical));
    }
    //private void FixedUpdate()
    //{
    //    Debug.Log("InFixedUpdate");
    //} 
    //private void LateUpdate()
    //{
    //    Debug.Log("InLateUpdate");
    //}

    //private void OnDestroy()
    //{
    //    Debug.Log("InDestroy");
    //}


    private void HandleDelegate()
    {
        Debug.Log("Player Ship Handled by Game Manager");
    }
}
