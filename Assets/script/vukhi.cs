using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vukhi : MonoBehaviour
{
    public static int st=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<kedich>();
        if (enemy)
        {
            enemy.takehit(st);

        }

    }
}
