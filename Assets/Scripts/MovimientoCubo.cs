using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        float movimientoX = 0f;
        if (Input.GetKey(KeyCode.D) == true)
        {
            movimientoX = movimientoX + 1f;
        }
    }
}
