using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController_7 : MonoBehaviour
{
    public float speedValue = 3.0f;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            speed = 1.5f * speedValue;
        }
        else
        {
            speed = speedValue;
        }


        float translationXAxis = Input.GetAxis("Horizontal");
        float translationZAxis = Input.GetAxis("Vertical");

        translationXAxis *= Time.deltaTime;
        translationZAxis *= Time.deltaTime;

        this.transform.Translate(translationXAxis * speed, 0, translationZAxis * speed, Space.World);

    }
}
