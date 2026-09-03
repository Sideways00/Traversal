using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float speed = 0.1f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed);
        }
    }
}
