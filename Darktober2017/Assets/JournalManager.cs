using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalManager : MonoBehaviour
{
    [SerializeField]
    GameObject Journal;
    [SerializeField]
    GameObject UIJournalButton;
   public bool showJournal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.gameObject.tag == "Player")
        {

            UIJournalButton.SetActive(true);

            showJournal = true;
        }
       


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
          UIJournalButton.SetActive(false);
    }

    private void Update()
    {
        
        if ( showJournal && Input.GetKeyDown(KeyCode.X))
        {
            //call pause function 
            Debug.Log("journal should appears");
            Journal.SetActive(true);
        }
        if (Journal.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            Journal.SetActive(false);
        }
    }

   
}
