using UnityEngine;

public class MuskratW7 : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Collider _collider;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _jumpForce = 5.0f;

    private bool _orbitMode;
    private Transform _sphereTransform;

    // ------------------------------------------------------------------------
    private void Update()
    {
        if (_orbitMode)
        {
            MoveOrbitMode();
        }
        else
        {
            MoveNormal();
        }

        Jump();
    }

    // ------------------------------------------------------------------------
    private void MoveOrbitMode()
    {
        // STEP 3 -------------------------------------------------------------
        // This movement code only runs when the Muskrat is on a bubble.
        //
        // Use leftright and _rotationSpeed to rotate the Muskrat again.
        // But this time, you'll need to convert the muskrat's up vector to
        //      WORLD SPACE.
        // This is because the Muskrat's up vector changes direction as it
        //      walks around a bubble, unlike when it's on a flat ground.
        //
        // You will need:
        // Transform.TransformDirection() https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Transform.TransformDirection.html
        // Transform.RotateAround () https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Transform.RotateAround.html
        //
        // You might want to look below Step 3 for an example :D

        
        float leftright = Input.GetAxis("Horizontal");
        
        //transform.TransformDirection(leftright * _rotationSpeed * Time.deltaTime * Vector3.up);
        Vector3 axisUp = transform.TransformDirection(Vector3.up);
        transform.RotateAround(_sphereTransform.position, axisUp, leftright * _rotationSpeed * Time.deltaTime);


        // STEP 3 -------------------------------------------------------------

        float forward = Input.GetAxis("Vertical");
        Vector3 axis = transform.TransformDirection(Vector3.right);
        transform.RotateAround(
            _sphereTransform.position,
            axis,
            forward * _rotationSpeed * Time.deltaTime
        );


        // STEP 5 -------------------------------------------------------------
        // Once again, set the "flying" and "running" parameters to animate 
        //      the Muskrat.
        // The Muskrat should never play the "flying" animation while on a
        //      bubble.


        // STEP 5 -------------------------------------------------------------
    }

    // ------------------------------------------------------------------------
    private void MoveNormal()
    {
        // STEP 1 -------------------------------------------------------------
        // This movement code only runs when the Muskrat is on flat ground.
        //
        // Use the input stored in leftright to rotate the Muskrat at
        //      _rotationSpeed speed.
        // Use the Transform.Rotate method: https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Transform.Rotate.html
        // and don't forget about Time.deltaTime :D
        //
        // Hint: you'll need to multiply leftright by one of the static Vector3 values:
        //      https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Vector3.html
        //      like up, left, right, or forward.

        float leftright = Input.GetAxis("Horizontal");
        transform.Rotate(leftright * _rotationSpeed * Time.deltaTime * Vector3.up);
        //why does this work?
        //we are rotating not translating

        // STEP 1 -------------------------------------------------------------


        // STEP 2 -------------------------------------------------------------
        float movement = Input.GetAxis("Vertical");

        // This line of code is incorrect. 
        // Replace it with a different line of code that uses 'movement' to
        //      move the Muskrat forwards and backwards.
        //transform.position += movement * Vector3.forward * _moveSpeed * Time.deltaTime; 
        //this line of code doesn't move the Muskrat forward once it is facing a direction different
        //from its spawn direction
        //transform.position = movement * _moveSpeed * Time.deltaTime;



        // STEP 2 -------------------------------------------------------------


        // STEP 4 -------------------------------------------------------------
        // Change the "flying" and "running" parameters on the Animator based
        //      on the Muskrat's movement to animate the Muskrat.
        // Use _rigidbody.linearVelocity.
        // You may also find the absolute value method, Mathf.Abs(), helpful:
        //      https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Mathf.Abs.html
        //_rigidbody.linearVelocity = ;

        // STEP 4 -------------------------------------------------------------
    }

    // ------------------------------------------------------------------------
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.isKinematic = false;
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);

            if (_sphereTransform != null)
            {
                Destroy(_sphereTransform.gameObject);
                _sphereTransform = null;
            }

            _orbitMode = false;
        }
    }

    // ------------------------------------------------------------------------
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            _orbitMode = true;
            _rigidbody.isKinematic = true;

            _sphereTransform = collision.transform;

            ContactPoint contact = collision.GetContact(0);

            Vector3 tangent = Vector3.Cross(Vector3.right, contact.normal);

            transform.SetPositionAndRotation(
                contact.point,
                Quaternion.LookRotation(tangent, contact.normal)
            );
        }
    }
}
