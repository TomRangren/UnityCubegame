using UnityEngine;

public class SpelareRörelse : MonoBehaviour
{
    public Rigidbody rb;
    public float FartFram = 2000f;
    public float SidoFart = 500f;
    // Bytte till FixedUpdate för att unity gillar det bättre när man använder fysik.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, FartFram * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SidoFart * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidoFart * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y<-1.5f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}