using System.Runtime.CompilerServices;
using UnityEngine;

public class ContadorEspacios : MonoBehaviour
{
    int vecesPulsado = 0;
    public float hoverForce = 5f;

    //Acceder arl rigidbody
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            vecesPulsado = vecesPulsado + 1;
            if (vecesPulsado == 5)
            {
                rb.AddForce(Vector3.up * hoverForce, ForceMode.Impulse);
                Debug.Log("HAS PULSADO " + vecesPulsado + " VECES");
                vecesPulsado = 0;
            }
            else
            {
                Debug.Log("He pulsado " + vecesPulsado);
            }

        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Que haces?");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("No te toco");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("WIII");
    }
}

