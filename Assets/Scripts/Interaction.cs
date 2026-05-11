using UnityEngine;
using TMPro;

public class Interaction : MonoBehaviour
{
    public Camera cam;
    public float interactDistance = 2f;

    public GameObject interactUI;
    public TextMeshProUGUI interactText;

    void Update() {
        InteractRay();
    }

    void InteractRay() {
        Ray ray = cam.ViewportPointToRay(Vector3.one/2f);
        RaycastHit hit;

        bool didHit = false;

        if(Physics.Raycast(ray, out hit, interactDistance)) {
            IIteractable interactable = hit.collider.GetComponent<IIteractable>();
            if(interactable != null) {
                didHit = true;
                interactText.text = interactable.GetDescription();

                if(Input.GetKeyDown(KeyCode.L)) {
                    interactable.Interact();
                }
            }
        }
        interactUI.SetActive(didHit);
    }
}
