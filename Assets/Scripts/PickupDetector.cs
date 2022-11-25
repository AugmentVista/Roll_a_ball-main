using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class PickupDetector : MonoBehaviour
{

   
    public TextMeshProUGUI countText;
    public GameObject loseTextObject; 
    private int count; 
   

    // Start is called before the first frame update
    void Start()
    {
       
        count = 0;
        SetCountText();
        loseTextObject.SetActive(false);
    }
    
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 1)
        {
            loseTextObject.SetActive(true);
        }
    }

    
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            //count = count + 1;
             count ++; 


        }
        void Update()
        {
             SetCountText();
        }






    }


}
