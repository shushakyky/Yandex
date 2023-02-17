using UnityEngine;

public class ScriptRope : MonoBehaviour
{
    private HingeJoint2D _hinge;
    public KeyCode bundle;
    private void Start()
    {
        _hinge = GetComponent<HingeJoint2D>();
    }

    private void Update()
    {
        if (Input.GetKey(bundle))
        {
            _hinge.enabled = false;
        }
    }
}
