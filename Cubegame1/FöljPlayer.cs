using UnityEngine;

public class FöljPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 Placering;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position+Placering;
    }
}
