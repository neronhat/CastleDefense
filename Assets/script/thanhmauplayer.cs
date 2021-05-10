using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class thanhmauplayer : MonoBehaviour
{
   // public float hpmax;
   // public static float hp;
    public Slider thanhhpplayer ;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void sethp(float mau, float maumax)
    {//hien thanh mau luc bi mat mau
       // thanhhpplayer.gameObject.SetActive(mau < maumax);
        thanhhpplayer.value = mau;
        thanhhpplayer.maxValue = maumax;
    }
    public void heal(int mau)
    {
        thanhhpplayer.value += mau;
    }

    // Update is called once per frame
    void Update()
    {
       
       // thanhhpplayer.transform.position = Camera.main.WorldToScreenPoint(new Vector3(transform.parent.position.x, transform.parent.position.y + 1.5f, 0));
        //transform.parent.position
    }

}
