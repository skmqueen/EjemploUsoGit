using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    //variable pública
    public string nombreDelObjeto = "Pepe";
    //variable de tipo entero
    int variable = 15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(nombreDelObjeto, gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        variable = variable + 1;
        Debug.Log(nombreDelObjeto + " en el Update " + variable);
    }
}
