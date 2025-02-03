using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Seller : MonoBehaviour
{
   public CinemachineVirtualCamera VCamDisable;
   public CinemachineVirtualCamera VCamEnable;
    public GameObject UI;
  
    private bool _canBuy = true;
    private float time = 1f;

    private void OnTriggerEnter(Collider other)
{
    if(_canBuy)
    {
        VCamDisable.gameObject.SetActive(false);
        VCamEnable.gameObject.SetActive(true);
        Camera.main.GetComponent<CinemachineBrain>().enabled = true;
        Camera.main.cullingMask &= ~(1 << 8);

        UI.SetActive(true);
        _canBuy = false;


    }


}

public void OnTriggerExit(Collider other)
{
    
}
public void ExitStore()
{
    
     VCamDisable.gameObject.SetActive(true);
        VCamEnable.gameObject.SetActive(false);
        Camera.main.GetComponent<CinemachineBrain>().enabled = false;
        Camera.main.cullingMask &= ~(1 << 8);
         UI.SetActive(false);

}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
