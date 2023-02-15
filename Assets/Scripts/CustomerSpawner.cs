using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    [SerializeField]
    TextAsset data;

    private string[] values;
    private Customer[] customers;

    // Start is called before the first frame update
    void Start()
    {
        char[] whitespace = new char[] { ' ', '\t', '\n' };
        string text = data.text;
        values = data.text.Split(whitespace);

        customers= new Customer[(values.Length)/3];

        int counter = 0;
        for(int i = 0; i < (values.Length-3); i+=3)
        {
            customers[counter] = new Customer(values[i], float.Parse(values[i + 1]), float.Parse(values[i + 2]));
            counter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
