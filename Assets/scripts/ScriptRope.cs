using UnityEngine;

public class ScriptRope : MonoBehaviour
{
    private HingeJoint2D _hinge;
    public KeyCode pop;
    private void Start()
    {
        _hinge = GetComponent<HingeJoint2D>();
    }

    private void Update()
    {
        if (Input.GetKey(pop))
        {
            _hinge.enabled = false;
            _hinge.connectedBody = null;
        }
    }
}
