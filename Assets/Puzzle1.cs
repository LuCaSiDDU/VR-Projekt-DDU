using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    public GameObject[] puzzle1;
    int n = 0;
    public AudioSource Audio;

    public void CheckButtonOrder(GameObject button)
    {
        if (button == puzzle1[n])
        {
            n++;
        }
        else
        {
            n = 0;
        }

        if (n == 3)
        {
            Audio.Play();
            n = 0;
        }

    }
}
