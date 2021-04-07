using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_Detector : MonoBehaviour
{
    public int counter = 0;

    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D()
    {
        counter++;
        StartCoroutine(Ball.GetComponent<Ball_Movement_Script>().ResetPosition(true));
    }
}
