using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaRef : MonoBehaviour
{

    void Start()
    {
        GameObject[] characters = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            characters[i] = transform.GetChild(i).gameObject;
            if (PlayerPrefs.GetInt("Number Gamer") == i)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
}
