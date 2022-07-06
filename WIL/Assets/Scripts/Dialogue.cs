using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue 
{
    /***************************************************************************************
 * Title: How to make a Dialogue System in Unity
 * Author: Brackeys
 * Date: 2017
 * Code version: N/A
 * Availability: https://www.youtube.com/watch?v=_nRzoTzeyxU&list=WL&index=28
 ***************************************************************************************/
    public string name;

    [TextArea(3,10)]
    public string[] sentences;
}
