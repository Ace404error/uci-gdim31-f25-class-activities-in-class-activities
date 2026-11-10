using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class BatManager : MonoBehaviour
{
    [SerializeField] private float _overlapDistance;
    [SerializeField] private float _interactDistance;
    [SerializeField] private float _timeBetweenNewMessages = 0.5f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private TMP_Text _reactionUiPrefab;
    // STEP 1 -----------------------------------------------------------------
    // Add a member variable named "_bats" that's an array of BatW6 Components.
    // In the Inspector, add ALL of the bats in the Scene.
    [SerializeField] private BatW6[] _bats;

    // STEP 1 -----------------------------------------------------------------

    // STEP 3 -----------------------------------------------------------------
    // Add a member variable named "_messages" that's an array of strings.
    // In the Inspector, add at least a few different messages for the bats to
    //      say when they reach the player.
    [SerializeField] string[] _messages;
    // STEP 3 -----------------------------------------------------------------

    [SerializeField] private float[] _newTextTimers;

    // ------------------------------------------------------------------------
    private void Start()
    {
        // STEP 6 -------------------------------------------------------------
        // Uncomment and FIX the below line to initialize _newTextTimers as a
        //      float array with the same length as _bats.
        // This array is used to keep track of all of the bats in the Scene
        //      and keep timers on them to avoid spawning their text too quickly
        //      whenever they reach the player.
        // Each index in _newTextTimers corresponds to a bat at the same index
        //      in _bats.
        // That means the bat at _bats[0] has a timer at _newTextTimers[0],
        //      the bat at _bats[1] has a timer at _newTextTimers[1],
        //      and so on.
        float[] _newTextTimers= new float[_bats.Length];
        
        //for (int i = 0; i<_bats.Length; i++) {
          //  _newTextTimers[i] = _bats[i];

        //}
        // STEP 6 -------------------------------------------------------------
    }

    // ------------------------------------------------------------------------
    private void Update()
    {
        // STEP 7 -------------------------------------------------------------
        // Loop through all of the entries in _newTextTimers, and increase each
        //      timer's value by the amount of time that passed this frame.
        for (int i = 0; i < _newTextTimers.Length; i++) {
            _newTextTimers[i] += Time.deltaTime;
        }

        // STEP 7 -------------------------------------------------------------

        // STEP 2 -------------------------------------------------------------
        // Write a for loop that visits all of the entires in the _bats array,
        //      and for each entry,
        //      check the distance between the bat and the player:
        //      IF the distance is less than _interactDistance, 
        //          make the bat chase the player;
        //          otherwise, make the bat STOP chasing the player.
        //
        // You will need to check the Vector3 documentation to find a method
        //      to help you with that distance check :)
        // https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Vector3.html
        //
        // STEP 4
        // Also inside this for loop, if the distance between the bat and the
        //      player is less than _overlapDistance, call CreateReactions()
        //      and pass the bat in as an argument.
        for (int i = 0; i < _bats.Length; i++)
        {
            if (Vector3.Distance(_bats[i].transform.position, _playerTransform.position)
                <= _interactDistance)
            {
                _bats[i].StopChase();
            }
            else
            {
                _bats[i].StartChase();
            }
            if (Vector3.Distance(_bats[i].transform.position, _playerTransform.position)
                <= _overlapDistance)
            {
                CreateReactions(_bats[i]);
            }
        }


        // STEP 2 -------------------------------------------------------------

    }

    // ------------------------------------------------------------------------
    private void CreateReactions(BatW6 bat)
    {
        // STEP 5 -------------------------------------------------------------
        // The Random.Range() method can be used to give us a random number
        //      between two values.
        // https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Random.Range.html
        // If you use floats as the arguments, it will return a float.
        // If you use ints as the arugments, it will return an int.
        //
        // Use Random.Range() to pick a RANDOM INDEX in the _messages array
        //      and call SpawnReactionUI() with the string at that index.
        // This should choose a random message to spawn every time one of the
        //      bats reaches the player.
        //
        // The first argument to SpawnReactionUI is same bat in the parameters
        //      of CreateReactions.
        int _randomMessage = Random.Range(0, _messages.Length - 1);
        string message = _messages[_randomMessage];
        SpawnReactionUI(bat, message);
        
        // STEP 5 -------------------------------------------------------------
    }

    // ------------------------------------------------------------------------
    // This method creates the Text GameObject at the location & with the 
    //      message specified by the parameters.
    // It also resets the _newTextTimers entry for that bat to 0.
    private void SpawnReactionUI(BatW6 bat, string message)
    {
        // STEP 8 -------------------------------------------------------------
        // We can create multi-line comments with the /* and */ symbol.
        // /* starts the comments, and */ ends it.
        // Simply uncomment the below lines by removing the /* and */ to finish.

        /*
        int index = System.Array.IndexOf(_bats, bat);
        
        GridLayoutGroup layout = bat.GetComponentInChildren<GridLayoutGroup>();
        if (layout != null && _newTextTimers[index] >= _timeBetweenNewMessages)
        {
            _newTextTimers[index] = 0.0f;
            TMP_Text textObj = Instantiate(_reactionUiPrefab, layout.transform);
            textObj.text = message;
        }
        */

        // STEP 8 -------------------------------------------------------------
    }
}
