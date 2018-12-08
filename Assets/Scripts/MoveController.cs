using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
public class MoveController : MonoBehaviour
{
    Rigidbody rb;
    float dirx;
    float moveSpeed = 20f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        dirx = Input.acceleration.x * moveSpeed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirx, 0f);
    }

    /*
    public Vector3 position; float Speed = 0; //Don't touch this 
    float MaxSpeed = 10; //This is the maximum speed that the object will achieve
    float Acceleration = 10; //How fast will object reach a maximum speed 
    float Deceleration = 10; //How fast will object reach a speed of 0 // Use this for initialization 
    void Start() { transform.position = position; }

        // Update is called once per frame
        void Update()
        {
            if ((Input.GetKey("left")) && (Speed < MaxSpeed)) Speed = Speed - Acceleration * Time.deltaTime;
            else if ((Input.GetKey("right")) && (Speed > -MaxSpeed)) Speed = Speed + Acceleration * Time.deltaTime;
            else
            {
                if (Speed > Deceleration * Time.deltaTime) Speed = Speed - Deceleration * Time.deltaTime;
                else if (Speed < -Deceleration * Time.deltaTime) Speed = Speed + Deceleration * Time.deltaTime;
                else
                    Speed = 0;
            }
            position.x = transform.position.x + Speed * Time.deltaTime;
            transform.position = position;
        }*/

}

