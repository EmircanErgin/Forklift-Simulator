using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKolKontrol : MonoBehaviour
{
    private Rigidbody2D rb;
    private float hareketHizi;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hareketHizi = 6f;
    }

    public void yukariHareket()
    {
        rb.velocity = Vector2.up * hareketHizi;
    }
    public void asagiHareket()
    {
        rb.velocity = Vector2.up * -hareketHizi;
    }
    public void hareketDurdur()
    {
        rb.velocity = Vector2.zero;
    }
    void Update()
    {
        
    }
}
