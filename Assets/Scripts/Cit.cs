using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cit : MonoBehaviour
{
    [SerializeField] private GameObject pan;
    [SerializeField] private GameObject pan1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Destroy(pan1);
            pan.SetActive(true);
        }
    }
}
