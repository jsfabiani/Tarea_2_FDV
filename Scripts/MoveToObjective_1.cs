using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveToObjective_1 : MonoBehaviour
{
    public Vector3 goal = new Vector3(1.0f, 0.0f, 3.0f);

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(goal);        
    }
}
