using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QUANLY : MonoBehaviour
{
    public Text diem;
    public static int tien;

    public static int sl;
    // Start is called before the first frame update
    void Start()
    {
        tien = 0;
        
    }
   void showtien()
    {
        diem.text = "Tien:" + tien;

    }

    // Update is called once per frame
    void Update()
    {
        showtien();
    }
}
