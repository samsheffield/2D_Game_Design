# Week 10
Welcome back! Today, we'll meet as a group to...
- Camera Follow
- Tilemaps (1/2)
- Sorting Layers

---

## Unity Demos

### Unity Demos for this week
- How to get the camera to follow a GameObject
- Sprite asset workflow in Unity
- Working with Unity's Tilemap Editor (1/2)
- Creating Rule Tiles
- Sorting Layers

#### Demo Materials
- Download the Tiny Town tilemap assets from Kenney.nl ([link](https://kenney.nl/assets/tiny-town)).
- Download this player movement script ([here](https://drive.google.com/file/d/1yXuPjMBOjeKXE_VJiEDZkih7ef5AZ_Zq/view?usp=sharing))
- Videos of today's demos will be available here by Thursday. 

## Next Week

### Demos
 - Working with the Animator (Triggering animation states)
 - More fun things with the Tilemap editor (GameObjects and Animated tiles)

# Homework

## Exercise 4: Exploration
This week you will be beginning a small game prototype that you'll work on over the next two weeks for homework. 

__Reminder: You are not permitted to use unlicensed artwork or music in your classwork. This includes others' IP (Intellectual Property). Please invent your own things!__

### Overview:
For this exercise, you will prototype a single level explorable by an animated player character. The level needs to have two things that we discover or interact with before we are allowed to leave/complete the level.

### For this week (Week 10):

1. Create three sketches of your level _on paper or using software other than Unity_. This will be your reference/key art where you establish the theme, look, and major actors of your prototype. 
    - What is in your world?
    - Who is your player?
    - What are we trying to do?
    - What kinds of things does the player interact with? 
    - Define the basic layout of your level.

2. Create a new Project file
    - Name the project Fourth_Game.
    - __Do not work on the Demo project we started in class tonight__. We will add more to it next week, so we want to keep it aside as a reference.

3. Create your tilemap(s)
    - Create your own tilemap sprite using whatever image making tool you'd like (note: this does not need to be pixel art, but it needs to adhere to a grid)
        - It does not need to be perfect of very complicated. Remember, you can always edit this image file later to make it better.
    - Make sure that you know the grid spacing that you are using so that you can set Pixels Per Unit in Import Settings properly.

4. Implement the tilemap in Unity
    - Import your sprites
    - Slice them up using the Sprite Editor
    - Create a Tilemap palette using the assets
    - Build your level using tilemaps in the Hierarchy
    - Remember: use different Tilemaps for things which need collision or not

5. Create one Rule Tile
    - Create at least one Rule Tile to use with your Tilemap

5. Add a moveable player prefab
    - Use a placeholder sprite for this week. Next week you can create an animated character.
    - Use the same kinds of scripts and components (Rigibdody2D, Collider2D) that we've been using so far.
    - Make sure the Sorting Layer Order is higher than your Tilemap Sprites. 
    - Tag this "Player".
    - Turn it into a prefab so it can be reused easily.

6. Add a camera that follows your player
    - Create a script that allows the camera to follow the player

6. Test it out
    - Try it out!
    - Can you move around and bump into things in an expected way?
    - Is everything visible?

### You will turn this in on April 2nd:
Do not submit this assignment to Canvas until April 2nd. Next week you will continue to develop the assignment for homework.

_Please bring your progress next week._

## Next Tuesday @ Noon: Jabari Weathers Talk
Jabari Weathers is an illustrator, writer, and tabletop game designer who has worked on games such as Bluebeard's Bride and the 3rd Edition of Betrayal at House on the Hill. Jabari will be here to talk about their work in D200. Please stop by!