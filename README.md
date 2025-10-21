# in-class-activities
## Devlogs
### W1
Hello World 

### W2
1. RGB variables are floats instead of int values since the computer has to calculate very precise color combinations between red, green, blue. This means that the code needs to make the color values floats in order to actually generate the precise color. Additonally, RGB can only be a number between 0.0 and 1.0, forcing the value to be an integer. 

2. The _bonuce variable is an int because its only caluclating the number of bouncess the ball has done, only being able to be a whole number. You can't have half a bounce or a quater of a bounce, making the _bonuce variable an int.

3.  THe error on step 4 of step 2 states that a double can't implicty convert to a float, meaning that all floats that are in the form of a double need to have an f at the end to cast it properly.

### W3
(Rhytmn game method) -  Table #2
1. The method should take a float with the time the player hit the note, then check if the player hit the note at the right time which would return true, other wise return a false.



Individual
1. Classes are like catagories and all of the componets within the class are like the items within a category. For instance, a "colors" category would have componets like red, blue, and green all contained with the class.

2. Since the balls brightness is increasing with the average value of linear velocity, the ball is become brigther and brighter with each bounce.


### W4
() - Table #2
1. In line 5, _moveSpeed declares a new variable that sets its value at 1.0f. Then, on line 22, a new float is created named translations that takes the vertical axis and mutiplies it by both the float _moveSpeed and Time.deltaTime. Finally, on line 25, the line calls transform, and uses the translate method (alters the shape) to set the last value to the translatino variable.

Individual
1. For the collider activity, we decided to to have set a rigidbody on both teh cat and ball, since those 2 objects will be colliding and will need to check the collsion of other objects. Futhurmore, we set isTrigger on he goal since the goal needs to trigger whenever the collides with the collider of the ball

2. Several times my ball and cat fell through the floor, and I fixed the issue by turning off the isTrigger in my confusion and also lifting the cat and ball up so they did not clip through the floor. 


## Open-Source Assets
### W1

- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 