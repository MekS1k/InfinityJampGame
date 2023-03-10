using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    [SerializeField]
    float speed;
    private Transform back_Transform;
    private float back_size;
    private float back_pos;
    void Start()
    {
        back_Transform=GetComponent<Transform>();
        back_size = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            speed = 5;
        }
        
         if (Input.GetMouseButtonUp(0))
         {
            speed = 1;
         }
         Move();
        
    }
    
       
    
    public void Move()
    {
        back_pos += speed * Time.deltaTime;
        back_pos = Mathf.Repeat(back_pos,back_size);
        back_Transform.position=new Vector3(0,back_pos,0);
    }
}
