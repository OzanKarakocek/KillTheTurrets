using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class KarakterKontrol : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody rb;
    public Transform groundCheck;
    public LayerMask groundMask;
    public float groundDistance = 0.4f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        // Sadece saða sola hareket et
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + transform.TransformDirection(movement));

        // Raycast ile zeminin eðimini kontrol et
        if (Physics.Raycast(groundCheck.position, -transform.up, groundDistance, groundMask))
        {
            // Eðer karakter yeterince yakýnsa, dengede kalmasý için düzeltme yap
            Vector3 projectedForward = Vector3.ProjectOnPlane(transform.forward, groundCheck.up);
            Quaternion rotation = Quaternion.LookRotation(projectedForward, groundCheck.up);
            transform.rotation = rotation;
        }
    }
}
