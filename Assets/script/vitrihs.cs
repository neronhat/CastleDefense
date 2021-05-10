using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vitrihs : MonoBehaviour
{

    public GameObject kedich;
  public  GameObject vitri;
    //public GameObject vitri2;
    //public GameObject vitri3;
    // Start is called before the first frame update
    float r1;
    void Start()
    {
        StartCoroutine(hskedich());
    }


    void kt()
    {
        if (QUANLY.sl <= 5)
            r1 = Random.Range(6f, 14f);
        if (QUANLY.sl >= 10)
            r1 = Random.Range(5f, 13f);
        if (QUANLY.sl >= 15)
            r1 = Random.Range(4f, 12f);


    }


    IEnumerator hskedich()
    {
        //r1 = Random.Range(2f, 12f);
        yield return new WaitForSeconds(r1);
      

        GameObject n1 = Instantiate(kedich, new Vector3(vitri.transform.position.x,vitri.transform.position.y,0),Quaternion.identity);
       
       
        StartCoroutine(hskedich());
    }

    // Update is called once per frame
    void Update()
    {
        kt();
    }
}
