using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenCounter : MonoBehaviour
{
    public int totalNumber = 0;
    public static EvenCounter Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;   
    }

    // Update is called once per frame
    void Update()
    {
        if (totalNumber==4)
        {
            UIController.Instance.won = true;
        }
    }
}
