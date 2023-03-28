using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viendanbay : MonoBehaviour
{
   
    public float tocdobay; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void dichuyen()
    {
        transform.Translate(tocdobay * Time.deltaTime, 0, 0);
    }


    



    // Update is called once per frame
    void Update()
    {
        dichuyen();
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enmeny = collision.collider.GetComponent<kedich>();
        if (enmeny)
        {
            enmeny.takehit(1);
            
        }
        Destroy(gameObject);
       
    }





}
