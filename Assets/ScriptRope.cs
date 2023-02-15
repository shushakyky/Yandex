using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptRope : MonoBehaviour
{
    private HingeJoint2D _hinge;
    public KeyCode bundle;
    private void Start()
    {
        _hinge = GetComponent<HingeJoint2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(bundle))
        {
            _hinge.breakForce = 0;
        }
    }
}
