# Medacta Candidate Exercise
The exercise follows the indications provided by Medacta
## Installation
Extract the package and launch the .exe file
# Usage
## Main Menu
The main menu after the launch of the application let the user choose the level to open.
#### Approach
Main Menu is controlled by MainMenuController.cs
Scenes are loaded and game is quit referring to this script.

## Main Level Scene
Main Level Scene is the scene containing the first scene, containing two objects (in this case two femoral implants).
### Movement
Both objects can be moved on the XZ plane by drag and drop with left click of the mouse.
#### Approach
Movement of the objects are guaranteed by DragScript.cs
On click on the object a variable opens the gate to dragging.
A virtual plane is created at a predefined height (in this case 1 unit).
Objects are initiated from the editor at this height. When dragging starts a ray is casted from the mouse position on the screen to the virtual plane. The resulting point will be the position of the object.

### Rotation
The objects can also be rotated by left clicking on them and dragging.


Vertical dragging will affect the yaw and horizontal dragging will affect the pitch.

Rolling is not directly affected but can be modified  orbiting the cursor around the object (most similar experience is the 3D orbiting in Solidworks)
#### Approach
Rotation is guaranteed by RotateScript.cs
On left click down on the object a ray is casted from the position of the mouse on the screen. If the ray touches the object with the applied script the rotation is permitted.
Mouse coordinates are read and multiplied to the rotation of the element.

### UI
A small UI follows Object1 indicating the distance and angle from Object2. Positive angle indicates Object 1 is on the right of Object2. Negative angle indicates the opposite.
#### Approach
The values of the UI are updated through ValueScript.cs
The distance is evinced from the vector resulting between the two objects.
The angle is the result of the method Vector3.SignedAngle between the absolute forward vector, the absolute up vector and the vector resulting from the two object positions.

The position of the UI is guaranteed by UI_PosScrip.cs
The position of the object is casted on the screen; UI follows that point.



### Color Changing
Object1 starts the scene with a red tint. As the objects approaches and begins to touch, Object1 becomes yellow. When Object1 and Object2 corresponds in position and angle (within a tolerance) Object1 becomes green.
#### Approach
Color change is guaranteed by ColorChangeScript.cs
A tolerance for distance and angle is hard-coded.
3 cases are created and changed along which conditions are respected.
Case 0: object do not touch
Case 1: object touch but angle and/or distance are out of tolerances
Case 2: object overlaps within tolerances

### Assumptions
• The objects are placed on an imaginary XZ plan positioned at Y = 1 and cannot be detached from it

• The distance and angle tolerance to detect correspondence between the two objects are hard-coded in the program based on personal tests

## Spring Level Scene
Spring Level Scene is a scene with the same two objects. Object1 is connected to Object2 with a spring-like invisible connector.
Object2 can still be dragged around.
Object1 can be pulled away from Object2 by dragging it.
#### Approach
The objects still have DragScript.cs and RotateScript.cs
Object1 has a Spring component and a mass applied to the object itself.
Object2 is unaffected by Object1

### Assumptions
• Object2 is placed on an imaginary XZ plan positioned at Y = 1 and cannot be detached from it

