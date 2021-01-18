using UnityEngine;

public class monstercontrol : MonoBehaviour
{




    private void OnTriggerEnter(Collider other)
    {
        
        if (other.name == "武器") 
        {
            Destroy(gameObject);
            GameObject.Find("GameObject").GetComponent<scoreManager>().Addscore();
        }
    }
}
