using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject nemico;
    
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            nemico.SetActive(true);
        }
    }
}
