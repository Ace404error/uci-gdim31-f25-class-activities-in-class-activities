# in-class-activities
## Devlogs
### W1
1. When the camera is moved out of the Cat GameObject parent group, the camera no longer follows the cat. That is, the camera won't move when the player presses the arrow keys.

2. Error: "Host type is not matching any asset type at Path Packages/com.unity.render-pipelines.core/Editor/Lighting/ProbeVolume/RenderingLayerMask/TraceRenderingLayerMask.urtshader.UnityEditor.AssetPostprocessingInternal:PostprocessAllAssets (string[],string[],string[],string[],string[],bool)"

### W2
1. Variables r, g, and b, are all floats instead of integers, bools, and strings because float values are essentially equivalent to decimals or fractions. As these variables are numerical, they wouldn’t be bools, which are true or false statements. By extension, they also wouldn’t be strings, as these are lines of text. Compared to float values, integers only represent whole numbers. If colors were to be represented accurately, the ball GameObject would have to cycle through color values that may not be equivalent to a whole number, hence, the reason for using float values over integer values.

2. Opposite to the r, g, and b variables, the _bounce variable represents a counter of how many times the ball GameObject bounces on the ground. As such, this value has to be an integer; it would be impossible to use decimal values to count the number of times a ball bounces.
 
3. There were two errors in this line of code. Not only was it missing a semi-colon, it was also missing the ”f” signifying the value to be a float, at the end of the 1.0. Without the semi-colon, it is as if the line of code never ended; the computer was expecting more details. Without the “f” at the end of 1.0, the computer attempted to read the value as a whole number, resulting in an error.


### W3

#### Activity 1:
1. Table 9, parameters = bool, return type = string

    You’re building a visual novel, and you’re writing a method named GetResponse that gives you a character’s text response to a player’s dialogue choice. The relevant data for the dialogue choice are the player’s current friendship level with the character and a flag that tells you whether or not the player knows the character’s secret.

2. Table 9, parameters = float

    You’re building a horror game, and you’re writing a method named SetLightDimness that makes the room’s lights brighter or darker based on the player’s current sanity level. The player’s sanity level is a number that goes from 0% - 100%. The method changes the light itself, so it doesn’t need any output.

3. Table 9, parameters = float, return type = bool

    You’re building a rhythm game, and you’re writing a method named DidPlayerHitBeat that tells you whether or not the player accurately hit a beat based on the time that they pressed a key.

#### Activity 2:



#### Activity 3:
1. I think the balls get extremely bright if they bounce too many times because there is no parameter to reset their brightness after reaching a certain level.

### W4
1. What solution did you come up with for the collider activity, and why? Specifically- which objects did you add Rigidbodies to, and which object(s) did you check Is Trigger on?
        The cat object and the ball object should both have Rigidbody components, as they both need to be able to bounce and move around. These objects however, don't need the IsTrigger box checked. This is because checking this box would prevent these objects from having physics interactions. On the other hand, the goal object does need the IsTrigger box checked because it should not move when the cat or ball crash into it; we are only checking if the ball rolls into it. It doesn't need to move at all, so it doesn't need a Rigidbody component.
   
3. IF your game did not work perfectly the first time you tested it, talk about what you had to fix.
        My game didn't work the first time. The Cat and ball objects were both spinning extremely rapidly when they collided with each other. Additionally, the cat object was spawning in the air. I had all of the colliders and IsTrigger boxes correct, the issue ended up being the size of the collider on the cat object. I was able to figure out that I could only change the size of the collider by going into the scene tab. I couldn't edit it at first because I was in the game tab.  
   Table #10


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
