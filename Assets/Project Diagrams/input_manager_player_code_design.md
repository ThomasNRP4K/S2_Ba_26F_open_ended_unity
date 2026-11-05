```mermaid
---
title: Input Manager and Player script connection
config:
  theme: base
  themeVariables:
    noteBkgColor: '#FFF2CC'
    noteBorderColor: '#D6B656'
    noteTextColor: '#000000'
---

classDiagram

	class InputManager{
		+Player player
		+HandleMovement()
		+HandleJump()
		+HandleAttack()
	}

	class Player{
		<<MonoBehaviour>>
		+speed: float
		+moveDirection : Vector2
		+Move(Vector2 inputDirection)
		+Jump()
	}


	%% Connections
	PlayerController *-- Player: Contains


	%% notes
	note "Note"




```
