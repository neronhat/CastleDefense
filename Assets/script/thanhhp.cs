using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class thanhhp : MonoBehaviour
{

   // public float hpmax;
    public Slider hp;
   // public static int mau;
    // Start is called before the first frame update
    void Start()
    {
        
        
       
        

    }

    public void sethp(float mau,float maumax)
    {//hien thanh mau luc bi mat mau
        hp.gameObject.SetActive(mau < maumax);
        hp.value = mau;
        hp.maxValue = maumax;
    }

    // Update is called once per frame
    void Update()
    {
        hp.transform.position = Camera.main.WorldToScreenPoint(new Vector3(transform.parent.position.x, transform.parent.position.y+1.5f,0));
        //transform.parent.position
    }


   
}
