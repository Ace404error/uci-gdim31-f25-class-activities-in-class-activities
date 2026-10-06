# in-class-activities
## Devlogs
### W1
1. When the camera is moved out of the Cat GameObject parent group, the camera no longer follows the cat. That is, the camera won't move when the player presses the arrow keys.

2. Error: "Host type is not matching any asset type at Path Packages/com.unity.render-pipelines.core/Editor/Lighting/ProbeVolume/RenderingLayerMask/TraceRenderingLayerMask.urtshader.UnityEditor.AssetPostprocessingInternal:PostprocessAllAssets (string[],string[],string[],string[],string[],bool)"

### W2
1. Variables r, g, and b, are all floats instead of integers, bools, and strings because float values are essentially equivalent to decimals or fractions. As these variables are numerical, they wouldn’t be bools, which are true or false statements. By extension, they also wouldn’t be strings, as these are lines of text. Compared to float values, integers only represent whole numbers. If colors were to be represented accurately, the ball GameObject would have to cycle through color values that may not be equivalent to a whole number, hence, the reason for using float values over integer values.

2. Opposite to the r, g, and b variables, the _bounce variable represents a counter of how many times the ball GameObject bounces on the ground. As such, this value has to be an integer; it would be impossible to use decimal values to count the number of times a ball bounces.
 
3. There were two errors in this line of code. Not only was it missing a semi-colon, it was also missing the ”f” signifying the value to be a float, at the end of the 1.0. Without the semi-colon, it is as if the line of code never ended; the computer was expecting more details. Without the “f” at the end of 1.0, the computer attempted to read the value as a whole number, resulting in an error.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
