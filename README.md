# Fist Tutorial/Example - Multiplayer unity. 



01. Create scene **lobby** (first scene of game)
02. Create scene **game**
03. Add scenes in project building (File -> Build Settings)


Cena lobby
========== 
Create empty gameobject: "NetworkLobbyManager". In this gameobject add,
Add "Network Lobby Manager (Script)"
Add "Network Manager Hud"
Configure the scenes created previously in this gameobject


Criar "player" - prefab (cubo). Neste gameobject adicionar
Criar script do player. Modificar herança para "NetworkBehaviour"
Add Network Transform. Transform Sync Mode(Sync Transform)
Transformar player em prefab e excluir do explorer
Configurar este prefab no "NetworkLobbyManager"

Criar prefab "LobbyPlayerGUI". 
Add "Network lobby player"
Transformar "LobbyPlayerGUI" em prefab e excluir do explorer
Configurar este prefab no "NetworkLobbyManager"

Cena game
Criar o cenário do jogo, no exemplo um plano
