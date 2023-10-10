using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metamorphosis : MonoBehaviour
{
    private bool entrance_roof = false;
    public GameObject player1;
    public GameObject player2;
    public GameObject rain1;
    public GameObject rain2;
    public GameObject rain3;
    public GameObject rain4;
    //variable for gui label style changes
    private GUIStyle guiStyle = new GUIStyle();

    // Update is called once per frame
    void Update()
    {
        if (entrance_roof == true && !player2.activeSelf)
        {
            if (Input.GetKeyDown("f"))
            {
                rain3.SetActive(true);
                rain4.SetActive(true);
                //delay 1sec
                StartCoroutine(JustWait());
                player2.SetActive(true);
                player1.SetActive(false);
                rain1.SetActive(false);
                rain2.SetActive(false);
            }
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        //ελεγχουμε αν το child count ειναι 1 ωστε να μην αλληλεπιδρα ο collider με το ιγκουανα (που εχει τουλαχιστον 2 παιδια)
        if (col.gameObject.tag == "Player" && col.gameObject.transform.childCount == 6)
        {
            entrance_roof = true;
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player" && col.gameObject.transform.childCount == 6)
        {
            entrance_roof = false;
        }
    }

    public void OnGUI()
    {
        guiStyle.fontSize = 16; //changing the font size
        guiStyle.normal.textColor = Color.white; //color
        guiStyle.alignment = TextAnchor.UpperCenter; //alignment
        if (entrance_roof && !player2.activeSelf)
        {
            if (Language_Script.lang_gr == false)
            {
                GUI.Label(new Rect(0, Screen.height / 2 + 100, Screen.width, 100), "Don't like your own skin? Press F to hop in for a ride.", guiStyle);
            }
            else
            {
                GUI.Label(new Rect(0, Screen.height / 2 + 100, Screen.width, 100), "Δε σου αρέσει το ίδιο σου το δέρμα? Πάτα F αν θες να δοκιμάσεις ένα άλλο.", guiStyle);
            }
        }
    }

    public IEnumerator JustWait()
    {
        yield return new WaitForSeconds(6);
    }

}
