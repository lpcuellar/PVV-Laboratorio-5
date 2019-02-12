using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public float range;
    public LayerMask layerMask;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1") && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, range, layerMask))
            {
                Debug.Log(hit.collider.name);
            }
        }
    }
}
