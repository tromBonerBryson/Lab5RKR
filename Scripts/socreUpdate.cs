using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socreUpdate : MonoBehaviour
{   
    public MoveForward livess;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(livess.lives);
    }
    
}
