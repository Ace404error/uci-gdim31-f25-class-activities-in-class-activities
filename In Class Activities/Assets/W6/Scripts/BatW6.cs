using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.XR;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;


    private void Update() {
        transform.position = Vector3.MoveTowards(
            transform.position, 
            _playerTransform.position,
            _speed
            );
        //every frame bats will move toward player position
    }
    //Start();
    //public bool StartChasing()
    //{
    //    return true;
    //}
    //public bool StopChasing()
    //{
      //  return true;
    //}

}
