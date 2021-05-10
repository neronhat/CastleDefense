using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tru : MonoBehaviour
{
    public GameObject tower;
    public GameObject viendan;
    public int solandanh;
    public int solandanhmax = 5;
    public thanhhp thanhmautru;
    public static int st=1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(taodan());
        //vitrikedich = kedich.GetComponent<Transform>();
        solandanh = solandanhmax;
        thanhmautru.sethp(solandanh, solandanhmax);
    }

    IEnumerator taodan()
        
    {
        float r1 = Random.Range(2f, 6f);

        yield return new WaitForSeconds(r1);
     GameObject n1=  Instantiate(viendan,new Vector3 (tower.transform.position.x+2,tower.transform.position.y,0), Quaternion.identity);
        Destroy(n1,6);
        StartCoroutine(taodan());
    }

    public void takehit(int sathuong)
    {
        solandanh -= sathuong;
        thanhmautru.sethp(solandanh, solandanhmax);
        if (solandanh <= 0)
            Destroy(gameObject);
    }

   



    // Update is called once per frame
    void Update()
    {
        
    }
}
