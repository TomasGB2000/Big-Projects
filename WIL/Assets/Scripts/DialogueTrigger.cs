using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    /***************************************************************************************
 * Title: How to make a Dialogue System in Unity
 * Author: Brackeys
 * Date: 2017
 * Code version: N/A
 * Availability: https://www.youtube.com/watch?v=_nRzoTzeyxU&list=WL&index=28
 ***************************************************************************************/
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
