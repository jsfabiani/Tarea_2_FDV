using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder_Collision : MonoBehaviour
{
    Material m_Cylinder;
    Color c_Impact;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        c_Impact = Color.red;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Floor")
        {
            m_Cylinder = collision.gameObject.GetComponent<Renderer>().material;
            m_Cylinder.color = c_Impact;
            Debug.Log(collision.gameObject.name);
            score += 1;
            Debug.Log("Score:");
            Debug.Log(score);
        }
    }
}
