using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MyComponent
{
    float speed = 5.0f;
    private Vector3 direction;
    private Vector2 inputVector;
    bool isMoving;
    //private Vector3 rotation = transform.rotation;
    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //get directional input
        inputVector = GameInput.Instance.GetMovementVectorNormalized();
        direction = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.Translate(direction*speed*Time.deltaTime,Space.World);

        //doesnt face forward when there is no input
        //if(direction!=Vector3.zero){   
        transform.forward = Vector3.Slerp(transform.forward, direction, 10F*Time.deltaTime);
        isMoving = direction!=Vector3.zero;
    }

    public bool IsMoving(){    
        return isMoving;
    }

    public bool IsRunning(){
        if(isMoving && Input.GetKey(KeyCode.LeftShift)){
            return true;
        }
        return false;
    }
    public bool IsJumping(){
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Jumping");
            return true;
        }
        return false;
    }
    
}
