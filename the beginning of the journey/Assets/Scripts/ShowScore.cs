using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowScore : MonoBehaviour
{
    public TextMeshProUGUI text;
    public static int[] scoremas ;
    int[] check = { 1, 2 };

    private void Start()
    {
        showrerecords();
    }

    static public string getrecords(int[] scoremas ) 
    { string text="";
        for(int i = 0; i < scoremas.Length; i++) 
        {
            text += i + 1+" место\t" + scoremas[i]+"\n";
        }
        return text;
    }
    public void showrerecords() 
    {

        scoremas = Data.scores();
        Array.Sort(scoremas);
        Array.Reverse(scoremas);
        text.text = getrecords(scoremas);
    }

    public void delete() 
    {
        PlayerPrefs.DeleteAll();
        showrerecords();

    }

}
