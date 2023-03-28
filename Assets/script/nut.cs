using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class nut : MonoBehaviour
{
   public player mauplayer;
    public thanhmauplayer hp;
    //public thanhmauplayer mau;
    // Start is called before the first frame update
   

    private void Start()
    {
        
    }

    public void dam()
    {
        if (QUANLY.tien >= 10)
        {
            QUANLY.tien -= 10;
            vukhi.st += 1;
        }
    }


  public void heal()
    {
        if (QUANLY.tien >= 20)
        {
            QUANLY.tien -= 20;
            // thanhmau.mauplayer.thanhhpplayer.value += 2;
            // mau.heal(2);
           mauplayer.solandanh += 2;
           hp.sethp(mauplayer.solandanh, mauplayer.solandanhmax);
            

        }
    }

    // Update is called once per frame
  
}
