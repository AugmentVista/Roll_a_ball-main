using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


/*public class winPickupDetector : MonoBehaviour
{


    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    private int count;


    // Start is called before the first frame update
    void Start()
    {

        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 1)
        {
            winTextObject.SetActive(true);
        }
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Finish"))
        {
            other.gameObject.SetActive(false);
            //count = count + 1;
            count++;


            SetCountText();
        }



    }


} */