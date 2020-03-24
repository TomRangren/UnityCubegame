using UnityEngine;
using UnityEngine.UI;

public class Räkning : MonoBehaviour
{
    public Transform player;
    public Text textRäkning;
    // Update is called once per frame
    void Update()
    {
        textRäkning.text = player.position.z.ToString("0");
    }
}
