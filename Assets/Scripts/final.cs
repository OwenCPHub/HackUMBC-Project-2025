using UnityEngine.SceneManagement;
using UnityEngine;

public class final : MonoBehaviour
{
    public GameObject objectthingy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeScene(){
        SceneManager.LoadScene("Scenes/final");
    }

    void OnTriggerEnter2D(Collider2D obj){
        changeScene();
    }
}
