# Week 3
Hello again Today, we'll meet as a group to...
- Review last week's Unity and C#
- Start programming with C#
- Move a player, create a goal, add some conflict (basic game design stuff)
- Import 2D images (sprites) into Unity
- What are game mechanics anyways?
- Defining player experience goals

---

## Review homework
Pull up your projects from homework. Hannah and I will go around and check your progress and answer any relevant questions you might have. Did you run into any difficulty?

---

## UNITY

### Unity Demo for this week
We'll do a lot of important groundwork over the next few weeks in class. We'll take a very hands-on approach to learning these technical materials. That means we'll probably encounter complex things that you don't fully understand at this point. That's okay! We'll be learning as we're making.

Please make sure to reach out to Sam or Hannah if you need any additional assistance understanding any of these things.

Today we'll discuss:
- Review conditional logic
- Collision vs Trigger events
- Using GameObject Tags
- Loading and restarting scenes


[Today's class notes will be uploaded here by Thursday morning](#). 

---

## What is a game mechanic?
Mechanics in a game are all of the activities which a player can do. They are central to a player's experience in most games. Common game mechanics include things like jumping, shooting, flying, collecting, crafting, healing, etc.

Of all these activities, the most consequential are the activities which a player performs most frequently. These are referred to as core mechanics. They are so central to the design of a game, that without them, you wouldn't be able play the game at all.

### Identifying core game mechanics
What are some core mechanics of games that you can identify? What makes them important to the experience of playing that game?

---

## Player Experience Goals
Player experience goals are goals that a game designer sets for the type of experience that players will have during the game.

- These are not features of the game but rather descriptions of the interesting and unique situations in which you hope players will find themselves. For example:
    - Players will have to cooperate to win, but the game will be structured so that they never trust each other.
    - Players will feel a sense of happiness and playfulness rather than competitiveness.
    - Players will have the freedom to pursue the goals of the game in any order they choose.
- What are your players thinking and feeling during the game?
- What meaningful choices facilitate these thoughts and feelings?

### Advocating for your players
Advocating for the player means experiencing game play from a player's perspective. It is an important part of creating fun and memorable games.

### What kind of experience are you designing?
- What kind of experience are you designing? 
- What goals do you have for your player?
- How do your core mechanics and level design reinforce your player experience goals?


# Homework

## Exercise 2: Unity, Let's Go!
This week, you'll complete the small game prototype that you started last week for homework. This exercise is intended to help you learn some basic C# scripting and Unity game development practices.

### Overview:
For this exercise, you will continue prototyping a simple game in which a player moves towards a goal while navigating a level. This week you will add some form of non-moving conflict to the level architecture which somehow complicates the player's ability to reach the goal in a fun and engaging way.

Your player will have a simple movement mechanic that you design using a combination of keyboard input and Rigidbody2D physics. 

_Experiment. Treat it like a toy. It doesn't need to be complicated to be fun._

Try to come up with something that feels satisfying to you in combination with your simple conflict and level architecture.

#### For this week (Week 3):
In your Level1 scene, add your conflict gameobjects and adjust your level to create a something fun which works with your movement mechanic.

When the player touches the conflict, reload the active scene. When the player reaches the goal, load the end scene.

Add a Start and End Scene with background graphics and instructions. The player should be able to press the space bar to advance your game to the next scene.

#### Important:
You are not expected to use anything more complex than what we do in class for this assignment. __Please do not begin searching around online for code to use for this exercise.__ You will almost certainly end up confusing things and in a frustrating place.


#### Technical goals for this week

- Project setup:
    - Continue developing the Unity Project you created and named First_Game.
    - After creating Start and End Scenes, add all 3 of your project's scenes to the Project Build Settings. 

- _Start_ Scene setup:
    - Create a new Scene and name it Start (make sure you are working in this scene!)
    - Add a background image to serve as a Start screen for your game. This image should indicate instructions for your game and the key to press to start. Make this image exactly 1920 x 1200px (this will fit a 16:10 display so keep in mind that 60px on top and bottom will be cut off on 16:9 displays).
    - Change the Main Camera's Size property so that its width of its viewport matches the width of the background image.
    - Create an empty GameObject in the scene and name it StartManager.

- _End_ Scene setup:
    - Create a new Scene and name it End (make sure you are working in this scene!)
    - Add a background image to serve as a Start screen for your game. This image should also indicate instructions for your game and the key to press to start it. Make this image exactly 1920 x 1200px (this will fit a 16:10 display so keep in mind that 60px on top and bottom will be cut off on 16:9 displays).
    - Change the Main Camera's Size property so that its width of its viewport matches the width of the background image.
    - Create an empty GameObject in the scene and name it EndManager.

- _StartManager_ GameObject setup:
    - Create and add a C# script called StartManager as a Component.
    - Write code in the StartManager script to load the Level1 scene after you press the space bar.

- _EndManager_ GameObject setup:
    - Create and add a C# script called EndManager as a Component.
    - Write code in the EndManager script to load the Start scene after you press the space bar.

- _Conflict_ GameObject setup:
    - Name this Conflict in the Hierarchy.
    - Use an imported sprite that represents the conflict.
    - Set Sprite Renderer's Order in Layer property set to 1.
    - Add a Collider 2D component (Choose from Box, Circle, or Polygon).
    - Set the Collider's Is Trigger property set to True (the box is checked).
    - Create and add a C# script called ConflictBehavior as a Component.
    - Write code in ConflictBehavior uses OnTriggerEnter2D to Destroy the Player (collision.gameObject) and then reload the active scene.

- _Player_ GameObject setup:
    - Add a Player tag to the player GameObject.

- _Goal_ GameObject setup:
    - Write code in the GoalBehavior script to load the End scene.
    

#### Important:
To submit this assignment to Canvas:

1. Locate the Project folder (you can use Unity Hub to do this).
2. Zip up the entire folder (make sure the  Unity project is not open when you do this or the process will fail).
3. Name the file _yourname_2d_exercise2.zip_
4. Upload it to your Google Drive and then submit the URL to the Canvas assignment.
