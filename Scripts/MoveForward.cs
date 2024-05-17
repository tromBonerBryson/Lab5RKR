using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoveForward : MonoBehaviour
{
    public float lives = 3;
    //public TextMeshProUGUI livesText;

   public float speed = 40.0f;
   private float Boundary = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //livesText.text = "Lives: " + lives;

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if(transform.position.x < -Boundary || transform.position.x > Boundary){
            Destroy(gameObject);
            lives = lives - 1;
        } 
    }
}
