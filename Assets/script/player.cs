using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player : MonoBehaviour
{
    public float tocdo = 5;
   
    public GameObject dao;
    public int solandanh;
    public int solandanhmax=5;

    public thanhmauplayer mauplayer;
    // Start is called before the first frame update
    void Start()
    {
        mauplayer.thanhhpplayer.maxValue = solandanhmax;
        mauplayer.thanhhpplayer.value = mauplayer.thanhhpplayer.maxValue;

        mauplayer.thanhhpplayer.value = solandanhmax;
        solandanh = solandanhmax;
        mauplayer.sethp(solandanh, solandanhmax);

    }
   // private SpriteRenderer xoay;
    private void Awake()
    {
       // xoay = GetComponent<SpriteRenderer>();
       
    }

    void dichuyen()
    {
        Vector3 quay = transform.localScale;

        if (Input.GetKey(KeyCode.A))

        {
            quay.x = -0.70043f;
            // xoay.flipX=true;
            transform.Translate(-tocdo * Time.deltaTime, 0, 0);
        }
         if (Input.GetKey(KeyCode.D))
        {
            quay.x = 0.70043f;
            //  xoay.flipX = false;
            transform.Translate(tocdo * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, tocdo * Time.deltaTime, 0);
         if (Input.GetKey(KeyCode.S))
            transform.Translate(0, -tocdo * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.Space))
               dao.SetActive(true);
        else
            dao.SetActive(false);
            transform.localScale = quay;

    }

    public void takehit(int satthuong)
    {
        solandanh -= satthuong;
        mauplayer.sethp(solandanh, solandanhmax);
        if (solandanh <= 0)
            Destroy(gameObject);


    }


    public void takeheal()
    {
        if (QUANLY.tien >= 20)
        {
            QUANLY.tien -= 20;

            solandanh += 2;
            mauplayer.sethp(solandanh, solandanhmax);
            if (solandanh <= 0)
                Destroy(gameObject);
        }

    }



    public void chem()
    {
        dao.SetActive(true);
    }
    

    // Update is called once per frame
    void Update()
    {
        dichuyen();
    }
}
