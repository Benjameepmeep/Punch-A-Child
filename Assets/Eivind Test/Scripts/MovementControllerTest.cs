using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControllerTest : MonoBehaviour
{
    private Vector2 move;
    public int speed;
    
    void Start()
    {
        
    }

    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //transform.Translate(move * speed * Time.deltaTime);
    }
}
