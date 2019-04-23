using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody rb; 
    public int count;
    public Text countText;
    // Start is called before the first frame update
    void Start()
    {
        this.count = 0;
        this.rb = GetComponent<Rigidbody>();
        this.countText.text = "Count: " + 0;
    }



    void FixedUpdate ()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float moververtical = Input.GetAxis("Vertical");
        float acclerationX= Input.acceleration.x;
        float acclerationY= Input.acceleration.y;

        Vector3 movement = new Vector3(movehorizontal + acclerationX, 0.0f, moververtical + acclerationY);

        this.rb.AddForce(movement * this.speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            Destroy(other.gameObject);
            //other.gameObject.SetActive(false);
            this.count++;
            this.countText.text = "Count: " + count;
        }
    }
}
