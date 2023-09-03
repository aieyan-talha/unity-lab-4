using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    private int randomNum;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        randomNum = Random.Range(149, 251);
    }

    // Update is called once per frame
    void Update()
    {
        ++i;
        Debug.Log(string.Format("{0}:{1}", gameObject.name, i));

        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.tag == "Blue" && i == randomNum)
        {
            gameObject.SetActive(false);
        }
    }
}
