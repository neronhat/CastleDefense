using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class kedich : MonoBehaviour
{
    public float sobuoc;
    public float thoigiandi;
    public float tocdo;
    public int solandanh;
    public int solandanhmax;
    public thanhhp thanhmau;
    public GameObject nv;
    private Transform vitrinv;
    public  GameObject tru;
    private Transform vitritru ;
    public GameObject tru2;
    private Transform vitritru2;
    public GameObject tru3;
    private Transform vitritru3;
    //private Vector2 vitriht;
    public float kc;
    

   
    void Start()
    {
       
        solandanh = solandanhmax;
        thanhmau.sethp(solandanh, solandanhmax);
        vitrinv = nv.GetComponent<Transform>();
        vitritru = tru.GetComponent<Transform>();
        vitritru2 = tru2.GetComponent<Transform>();
        vitritru3 = tru3.GetComponent<Transform>();
        //vitriht = GetComponent<Transform>().position;

    }

    public void takehit(int sathuong)
    {
        solandanh -= sathuong;
        thanhmau.sethp(solandanh, solandanhmax);
        if (solandanh <= 0)
        {
            Destroy(gameObject);
            QUANLY.tien += 10;
            QUANLY.sl += 1;
        }
    }



    public void timduong()
    {
        
       float r2 = Random.Range(-2, 2);

        try
        {
            if (Vector2.Distance(transform.position, vitrinv.position) < kc)
            {
                transform.position = Vector2.MoveTowards(transform.position, new Vector3(vitrinv.position.x + r2, vitrinv.position.y + r2), tocdo * 0.2f * Time.deltaTime);
           

            }

            else if (Vector2.Distance(transform.position, vitritru.position) < kc )
            {
                transform.position = Vector2.MoveTowards(transform.position, new Vector3(vitritru.position.x + r2, vitritru.position.y ), tocdo * 0.2f * Time.deltaTime);

            }
            else if (Vector2.Distance(transform.position, vitritru2.position) < kc)
            {
                transform.position = Vector2.MoveTowards(transform.position, new Vector3(vitritru2.position.x + r2, vitritru2.position.y ), tocdo * 0.2f * Time.deltaTime);

            }
            else if (Vector2.Distance(transform.position, vitritru3.position) < kc)
            {
                transform.position = Vector2.MoveTowards(transform.position, new Vector3(vitritru3.position.x + r2, vitritru3.position.y ), tocdo * 0.2f * Time.deltaTime);

            }
        }
       finally
        { 
        {

                //if (Vector2.Distance(transform.position, vitriplayer.position) <= 0)
                //{

                //}

                //else
                //    transform.position = Vector2.MoveTowards(transform.position, vitriht, tocdo * Time.deltaTime);
                dichuyen();

            } }
       

    }

  public  void dichuyen()
    {
        thoigiandi += Time.deltaTime;
        if (thoigiandi <= 3 && sobuoc == 10)

        {
            transform.Translate(-tocdo * Time.deltaTime, 0, 0);
            sobuoc = 0;
            thoigiandi = 0;
        }
        else
            sobuoc += 1;
      

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var tru = collision.collider.GetComponent<tru>();
        if (tru)
        {
            tru.takehit(1);

        }


        var player = collision.collider.GetComponent<player>();
        if (player)
        {
            player.takehit(1);
        }


    }

    // Update is called once per frame
    void Update()
    {
        timduong();
    }

    


}
