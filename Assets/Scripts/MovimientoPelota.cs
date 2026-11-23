using Unity.VisualScripting;
using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    public float speed = 10;
    Vector3 dir;
    private void Start()
    {
        dir = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f));
        dir.Normalize();
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("He chocado con " + collision.gameObject.name);


        if (collision.gameObject.CompareTag("Horizontal"))
        {

        }
    }
}