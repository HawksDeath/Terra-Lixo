using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translacao : MonoBehaviour
{
    public Transform Pai;
    public float VelTrans;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Pai.position, transform.up, VelTrans * Time.deltaTime);
    }
}
