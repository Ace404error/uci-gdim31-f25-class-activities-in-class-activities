using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Android;

class DeerObject : MonoBehaviour {
    [SerializeField] Transform _walkToward;
    [SerializeField] float _speed = 1.0f;
    NavMeshAgent _navMeshVar;
    //NavMeshAgent is a var type too!

    void Start()
    {
        _navMeshVar = GetComponent<NavMeshAgent>();
        _navMeshVar.SetDestination(_walkToward.position);
        //.position gets the exact position of the Transform
    }

};
// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...