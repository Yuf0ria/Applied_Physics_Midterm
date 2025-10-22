using TMPro;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    //serializefields
    float distances = 10;
    [SerializeField] LayerMask Begin, Finish; //pang check kung start or End
    [SerializeField] Color color;

    //Text
    public TMP_Text Verify;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            Verify.text = "Hold E to Verify";
        }
    }

    public void Interact()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, distances, Begin))
        {
            Debug.Log($"Object name {hitInfo.transform.name}");
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);

            Verify.text = "Start";
        }
        else if (Physics.Raycast(ray, out hitInfo, distances, Finish))
        {
            Debug.Log($"Object name {hitInfo.transform.name}");
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);
            
            Verify.text = "Finish";

        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * distances, Color.blue);
            Verify.text = "Just Walls";
        }
    }
    
}
