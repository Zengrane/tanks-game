using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    // the character this healthbar represents
    public TankHealth ch;

    // image to scale as health bar
    public Image image;
   
   

    Rect initialRect;

    // Update is called once per frame
    void Update()
    {
        // TODO - variable character height instead of the 2 below?
        // position the meter above the character's head
        transform.position = ch.transform.position + Vector3.up * 2;
        transform.forward = Camera.main.transform.forward;

        // scale the meters (health and energy)
        // they need to be Filled type for this to work
        image.fillAmount = Mathf.Clamp01(ch.m_StartingHealth / ch.maxStartingHealth);

       
    }
}