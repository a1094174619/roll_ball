using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupsfactory : MonoBehaviour
{
    private float creatTime = 1.0f; 
    public GameObject pickup;
    public GameObject target;
    private float scale;
    // Start is called before the first frame update
    void Start()
    {
        this.scale = 4.0f;
    }

    // Update is called once per frame
    void Update()
    {
        creatTime -= Time.deltaTime;
        if (creatTime <= 0)
        {
            creatTime = Random.Range(1, 4);
            this.target = Instantiate<GameObject>(this.pickup);
            this.target.SetActive(true);
            this.target.transform.position = new Vector3(Random.Range(-scale, scale), 0.5f, Random.Range(-scale, scale));
        }
    }
}
