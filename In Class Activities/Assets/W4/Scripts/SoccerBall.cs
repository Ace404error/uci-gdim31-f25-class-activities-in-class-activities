using System.ComponentModel.Design.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SoccerBall : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private TMP_Text _timeText;
    [SerializeField] private ParticleSystem _goalVFX;
    private int pointTracker;
    private float lastGoal;

    // STEP 1 -----------------------------------------------------------------
    // The OnTriggerEnter method is a collision method called by Unity that
    //      tells our object when it's hit a collider with Is Trigger checked.
    // Uncomment and FIX the METHOD SIGNATURE to make this method work.
    //
    // You will need to read the documentation here:
    // https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Collider.OnTriggerEnter.html
    //      which has an example of a class using this method :)
    //
    // You'll also need to have all of your colliders set up properly in the Scene ;)
    //
    // Also, uncomment and FIX the Debug.Log line.

    private void OnTriggerEnter()
        //ALWAYS add parenthesis at the end when declaring a method!!
    {
        // finish STEP 1 by uncommenting and fixing the below line!
        

        // STEP 2 -------------------------------------------------------------
        // Write an IF STATEMENT to check if the game object we collided with
        //      has the tag "Goal".
        // Refer to the slides for an example of how to check this :)
        //
        // Then, move your Debug.Log() statement so that it's only called if
        //      the colliding object has the "Goal" tag.
        if (gameObject.tag == "Goal") {
            MadeGoal();
        };
        


        // STEP 2 -------------------------------------------------------------
    }

    // STEP 1 -----------------------------------------------------------------


    // STEP 3 -----------------------------------------------------------------
    // Next, we're going to make a method named MadeGoal to call if the
    //      SoccerBall collided with an object tagged "Goal".
    // MadeGoal RETURNS NOTHING, and has NO INPUT.
    // 
    private void MadeGoal()
    {
        Debug.Log("SoccerBall detected a collision with a trigger collider!");
        pointTracker += 1;
        _pointsText.text += 1;
        lastGoal = 0;

    }
    // Once you've created MadeGoal,
    //      move your Debug.Log() statement into MadeGoal, and
    //      call MadeGoal from inside your if statement in OnTriggerEnter.
    //and thats what we call abstraction folks :D

    // STEP 4 -------------------------------------------------------------
    // _goalVFX is a ParticleSystem, a Component for creating VFX.
    // ParticleSystem has a method named Play() that displays the VFX:
    // https://docs.unity3d.com/6000.0/Documentation/ScriptReference/ParticleSystem.Play.html 
    //
    // Call Play on _goalVFX.
    public void Play(ParticleSystem _goalVFX) {
        

    }
    public void Update()
    {
        _timeText.text += lastGoal;
    }
    // STEP 4 -------------------------------------------------------------


    // STEP 3 -----------------------------------------------------------------


    // STEP 5 -----------------------------------------------------------------
    // I am doing something evil, but I believe in you.
    // These STEP flags don't actually show you where to write the code next.
    //
    // We want our code to keep track of the number of points the player has,
    //      and change the text on _pointsText when they earn a point by
    //      making a goal.
    //
    // Do your best to code this.
    //
    // You will need to:
    //      1. Create a new member variable to keep track of the points.
    //      2. Use your MadeGoal method to update the points and text.
    //
    // STEP 5 -----------------------------------------------------------------


    // STEP 6 -----------------------------------------------------------------
    // Like the last step, these flags do NOT show you where to put all of the
    //      code that you need to write.
    //
    // We want to keep track of how long it's been since the last time the
    //      player scored a goal, and update _timeText with that time.
    // Your time variable should increase EVERY FRAME with how much TIME has 
    //      passed, and reset to ZERO when we MAKE A GOAL.
    //
    // You will need to:
    //      1. Use a Unity method to increase your time variable every frame
    //              and update _timeText with the new time.
    //      2. Use the MadeGoal method to reset your
    //              time variable when the player makes a goal. 

    // STEP 6 -----------------------------------------------------------------
}
