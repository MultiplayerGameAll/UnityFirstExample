# Fist Tutorial/Example - Multiplayer unity. 



01. Create scene **lobby** (first scene of game)
02. Create scene **game**
03. Add scenes in project building (File -> Build Settings)


## lobby scene


### Create empty gameobject: "NetworkLobbyManager". In this gameobject add,

Add "Network Lobby Manager (Script)"

Add "Network Manager Hud"

Configure the scenes created previously in this gameobject


### Create "player" - prefab (cube). In this gameobject add,

[Player.cs](Player.cs), script available in this repository. 

Add Network Transform. Set *Transform Sync Mode* parameter to  *Sync Transform*

Remember to change this object in prefab and remove from Unity Hierarchy

Configure this prefab in "NetworkLobbyManager"


### Create prefab "LobbyPlayerGUI". 

Add "Network lobby player"

Remember to change this object, "LobbyPlayerGUI", in prefab and remove from Unity Hierarchy

Configure this prefab in "NetworkLobbyManager"

## **game** scene

Create the game in this scene. Example: a plain.

