using UnityEngine;

public class activatepassword : MonoBehaviour
{
    public GameObject enableObj;

    void OnTriggerEnter2D(Collider2D obj){
        enableObj.SetActive(true);
    }
}
