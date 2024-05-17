using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float horizontalInput;
    public float forwardInput;
    
    public float speed = 10.0f;
    //private float xRange = 10.0f;
    private float topBound = 7.0f;
    private float leftBound = -30.0f;
    private float rightBound = 30.0f;
    private float zRange = 6.0f;
    public float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < leftBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, leftBound);
        }

        if (transform.position.z > rightBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, rightBound);
        }
        
        if (transform.position.x < -topBound)
        {
            transform.position = new Vector3(-topBound, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > zRange)
        {
            transform.position = new Vector3(zRange, transform.position.y, transform.position.z);
        }
        forwardInput = Input.GetAxis("Horizontal");

        scoreText.text = "Score: " + score;
        
        //Move the vehicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime);
    
        
        horizontalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.left * horizontalInput * Time.deltaTime * speed);


        
    }

     private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Animal"))
        {
            score = score + 1;
            Destroy(other.gameObject);
        }
    }
}
