using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update

    public int i=0;
    public TMP_Text Text;
    public GameObject cube;
    void Start()
    {
        i=10;
        print(i);
    }

    // Update is called once per frame
    void Update()
    {
       i++; 
       Text.text = i+" ";
       cube.transform.Translate(Vector3.forward * Time.deltaTime*100);
       //gameObject.transform.Translate(Vector3.forward * Time.deltaTime*100);
       if(Input.GetKeyUp(KeyCode.Space))
       {
        Debug.LogWarning("I am in Space");
       }
    }
}
