using UnityEngine;

public class MovimientoJugadorSimple : MonoBehaviour
{
    public float fuerzaMovimiento = 20f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }

        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * fuerzaMovimiento);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * fuerzaMovimiento);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * fuerzaMovimiento);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * fuerzaMovimiento);
        }
    }
}