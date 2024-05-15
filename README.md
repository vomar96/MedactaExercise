# Medacta Candidate Exercise
The exercise follows the indications provided by Medacta
## Installation
Extract the package and launch the .exe file
## Usage
### Main Menu
The main menu after the launch of the application let the user choose the level to open.
### Main Level Scene
Main Level Scene is the scene containing the first scene, containing two objects (in this case two femoral implants).
#### Movement
Both objects can be moved on the XZ plane by drag and drop with left click of the mouse.
#### Rotation
The objects can also be rotated by left clicking on them and dragging.

Vertical dragging will affect the yaw and horizontal dragging will affect the pitch.

Rolling is not directly affected but can be modified  orbiting the cursor around the object (most similar experience is the 3D orbiting in Solidworks)
#### UI
A small UI follows Object1 indicating the distance and angle from Object2. Positive angle indicates Object 1 is on the right of Object2. Negative angle indicates the opposite.
#### Color Changing
Object1 starts the scene with a red tint. As the objects approaches and begins to touch, Object1 becomes yellow. When Object1 and Object2 corresponds in position and angle (within a tolerance) Object1 becomes green.
#### Assumptions
• The objects are placed on an imaginary XZ plan positioned at Y = 1 and cannot be detached from it

• The distance and angle tolerance to detect correspondence between the two objects are hard-coded in the program based on personal tests

### Spring Level Scene
Spring Level Scene is a scene with the same two objects. Object1 is connected to Object2 with a spring-like invisible connector.
Object2 can still be dragged around.
Object1 can be pulled away from Object2 by dragging it.
#### Assumptions
• Object2 is placed on an imaginary XZ plan positioned at Y = 1 and cannot be detached from it
