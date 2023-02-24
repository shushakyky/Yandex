using Unity.VisualScripting;
using UnityEngine;

public class a_bundle_with_a_rope : MonoBehaviour
{
    [SerializeField] private string _tag;

    private HingeJoint2D _hinge;
    private string __tag;
    public KeyCode bundle;

    private void Awake()
    {
        _hinge = GetComponent<HingeJoint2D>();
        __tag = gameObject.tag;
    }

    private void OnTriggerEnter2D(Collider2D a)
    {
        if (Input.GetKey(bundle))
        {
            if (a.gameObject.tag != __tag)
            {
                Rigidbody2D next_hinge = a.gameObject.GetComponent<Rigidbody2D>();
                _hinge.connectedBody = next_hinge;
                _hinge.enabled = true;
                __tag = a.gameObject.tag;
            }
        }
    }

}
