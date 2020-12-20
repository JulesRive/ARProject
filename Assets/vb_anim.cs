using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour
{
    private GameObject avion;
    private GameObject btnTest;
    private GameObject btnTicket;
    private GameObject ticket;
    // Start is called before the first frame update
    void Start()
    {
        btnTest = GameObject.Find("VirtualButton");
        btnTicket = GameObject.Find("SecondButton");
        btnTest.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        btnTest.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        btnTicket.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        btnTicket.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        avion = transform.Find("flightModel").gameObject;
        ticket = transform.Find("Ticket").gameObject;
        avion.SetActive(false);
        ticket.SetActive(false);

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        Debug.Log(vb.VirtualButtonName);
        if (vb.VirtualButtonName == "VirtualButton")
        {
            avion.SetActive(true);
            Debug.Log("Avion Button Pressed");
        }
        if (vb.VirtualButtonName == "SecondButton")
        {
            ticket.SetActive(true);
            Debug.Log("ticket Button Pressed");
        }

    }

    
    public void OnButtonReleased(VirtualButtonBehaviour vb) 
    {
        if (vb.VirtualButtonName == "VirtualButton")
        {
            avion.SetActive(false);
            Debug.Log("Avion Button NOPE");
        }
        if (vb.VirtualButtonName == "SecondButton")
        {
            ticket.SetActive(false);
            Debug.Log("ticket Button NOPE");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
