using UnityEngine;

public class Krock : MonoBehaviour
{
    public SpelareRörelse movement;
  
   void OnCollisionEnter(Collision KrockInfo)
    {
        if(KrockInfo.collider.tag== "Hinder")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
