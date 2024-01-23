# Week 2
Hello again Today, we'll meet as a group to...
- Remind us who you are and say hello to new people
- Take first real steps in Unity game development
- Start programming with C#
- Move a player, create a goal, add some conflict (basic game design stuff)
- Import 2D images (sprites) into Unity
- What are game mechanics anyways?

---

## Review homework
Pull up your projects from homework. Hannah and I will go around and check your progress and answer any relevant questions you might have. 

Remember, we were looking for specific things in this one:
- You have imported a 128 x 128px sprite.
- You've set the camera's background color to _red_.
- You've set the sprite's transform position to X: -12 Y: 1 Z: 0.
- You've done this all in a scene called TestScene.

---

## Begin working with Unity

### Make sure Visual Studio is installed
Our text editor is an important tool in our toolkit, so we need to make sure it's installed and working properly.
- Try opening Visual Studio and make sure that it launches.
- We're going to create a C# script to make sure things are connecting up okay. If things work unexpectedly, Hannah and I will provide some assistance.

#### Autocomplete not working?
Visual Studio has a powerful autocompletion for C# called Intellisense. Support for Unity should have been added when you installed the editor, but sometimes the connection is not set explicitly in Unity. 

If you are not getting autocompletion for Unity C#:
- Go to Edit > Preferences > External Tools and set the External Script Editor from Open by file extension to the name of your text editor in the dropdown menu.
- Then click the Regenerate project files button.

#### Microsoft account
Visual Studio will probably inform you that you need to sign in with a Microsoft account. Please set this up before the trial period runs out to avoid any unexpected frustration.

### Unity Demo for this week
We'll do a lot of important groundwork over the next few weeks in class. We'll take a very hands-on approach to learning these technical materials. That means we'll probably encounter complex things that you don't fully understand at this point. That's okay! We'll be learning as we're making.

Please make sure to reach out to Sam or Hannah if you need any additional assistance understanding any of these things.

Today we'll discuss:
- Importing Sprites
- Working with the Project window 
- What is scripting in Unity?
- Basics concepts and structure of C# (see-sharp) programming for Unity
- Critical programming vocabulary
- Creating components with C# and adding them to GameObjects
- Using a keyboard to move a GameObject 
- What is a Rigidbody?
- Collision, two ways.
- Conditional logic: creating cause and effect
- Destroying a GameObject

[Today's class notes will be uploaded here before the end of day on Wednesday](#). 

---

## What is a game mechanic?
Mechanics in a game are all of the activities which a player can do. They are central to a player's experience in most games. Common game mechanics include things like jumping, shooting, flying, collecting, crafting, healing, etc.

Of all these activities, the most consequential are the activities which a player performs most frequently. These are referred to as core mechanics. They are so central to the design of a game, that without them, you wouldn't be able play the game at all.

### Identifying core game mechanics
What are some core mechanics of games that you can identify? What makes them important to the experience of playing that game?
# Homework

## Exercise 2: Unity, Let's Go!
This week you'll begin a small game prototype that you'll work on over the next two weeks for homework. This exercise is intended to help you learn some basic C# scripting and Unity game development practices.

### Overview:
For this exercise, you will prototype a simple game in which a player moves towards a goal while avoiding some kind of conflict. You will design the conflict and level architecture to somehow complicate the player's ability to reach the goal in a fun and engaging way.

Your player will have a simple movement mechanic that you design using a combination of keyboard input and Rigidbody2D physics. 

_Experiment. Treat it like a toy. It doesn't need to be complicated to be fun._

Try to come up with something that feels satisfying to you in combination with your simple conflict and level architecture.

#### For this week (Week 2):
Get your player moving around using keyboard input, set up your goal, your sources of conflict, and design a little level using placeholder sprites that help

#### Important:
You are not expected to use anything more complex than what we do in class over the next two weeks. __Please do not begin searching around online for code to use for this exercise.__ You will almost certainly end up confusing things and in a frustrating place.


#### Technical goals for this week

- Project setup:
    - Create a new Unity Project using the 2D Core template and name it First_Game.

- Scene setup:
    - Create a new Scene and name it Level1 (make sure you are working in this scene!)
    - Add a background image to your scene which is exactly 1920 x 1200px (this will fit a 16:10 display so keep in mind that 60px on top and bottom will be cut off on 16:9 displays).
    - Change the Main Camera's Size property so that its width of its viewport matches the width of the background image.
    - Use 4 placeholder sprite GameObjects created in the Hierarchy (Right click in Hierarchy > 2D Object > Sprites > Square) to create a wall around the Main Camera viewport that keeps the player from leaving the playable area.

- _Player_ GameObject setup:
    - Name this Player in the Hierarchy
    - An imported sprite that represents the player.
    - Set Sprite Renderer's Order in Layer property set to 2.
    - Add a Rigidbody2D and a Collider 2D component (Choose from Box, Circle, or Polygon)
    - Create a C# script called PlayerMovement and add it as a Component to Player.
    - Write code in PlayerMovement to move the player's Rigidbody2D component with keys on your keyboard.

- _Goal_ GameObject setup:
    - Name this Goal in the Hierarchy
    - An imported sprite that represents the goal.
    - Set Sprite Renderer's Order in Layer property set to 1.
    - A Collider 2D component (Choose from Box, Circle, or Polygon).
    - The Collider's Is Trigger property set to True (the box is checked).
    - Create and add a C# script called GoalBehavior added as a Component.
    - Write code in GoalBehavior that uses OnTriggerEnter2D to Destroy itself (gameObject).

- _Conflict_ GameObject setup:
    - Name this Conflict in the Hierarchy.
    - Use an imported sprite that represents the conflict.
    - Set Sprite Renderer's Order in Layer property set to 1.
    - Add a Collider 2D component (Choose from Box, Circle, or Polygon).
    - Set the Collider's Is Trigger property set to True (the box is checked).
    - Create and add a C# script called ConflictBehavior as a Component.
    - Write code in ConflictBehavior uses OnTriggerEnter2D to Destroy the Player (collision.gameObject).

- _Level architecture_ GameObjects setup:
    - Use placeholder sprites created in the Hierarchy (Right click in Hierarchy > 2D Object > Sprites > Anything _except_ 9-Slice)
    - Include a Collider 2D Component (which will be created with it).
    - Rename these Obstacle.
    - Rescale using the Scale tool.
    

#### Important:
__Do not submit this assignment to Canvas this week.__ Next week you will continue to develop this assignment for homework and turn it in on February 6th. 

_We will take a look at this homework in class next week._

## Optional: Global Game Jam!
Global Game Jam (GGJ) starts this Friday (Jan 26th). This is a great opportunity to warm up, finish a small game for your portfolio, work with new people/work with old friends/work by yourself, and have fun! **Don't worry if you've never made a game before, you have so many skills to contribute to a team.**

FYI: The GGJ consistently pops up in conversations with visiting game developers as something they view _very positively_ from prospective employees. It demonstrates your engagement with game development outside of school assignments, your ability to meet deadlines and work within constraints, and (possibly) your ability to work with others. 


Sign up [here](https://globalgamejam.org/jam-sites/2024/mica-game-design).