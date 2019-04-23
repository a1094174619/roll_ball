using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody rb; 
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        this.rb = GetComponent<Rigidbody>();
    }



    void FixedUpdate ()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float moververtical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movehorizontal, 0.0f, moververtical);

        this.rb.AddForce(movement * this.speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
        }
    }
}
