using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement_Script : MonoBehaviour
{
    
    public float speed = 0.0f;
    private Rigidbody2D rb;

    public GameObject Ball_SpawnPoint;

    public int WaitTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(ResetPosition(false)); 
    }

    public IEnumerator ResetPosition(bool wait)
    {
        transform.position = Ball_SpawnPoint.transform.position;
        rb.velocity = new Vector2(0f, 0f);

        if(wait)
        {
            yield return new WaitForSeconds(WaitTime);
        }

        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
