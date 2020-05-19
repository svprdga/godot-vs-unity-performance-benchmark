extends Node2D

const BALL = preload("res://Ball.tscn")

onready var text = get_node("/root/Node2D/Label")

var balls = 0

func _ready():
	var timer = Timer.new()
	timer.connect("timeout",self,"_on_timer_timeout")
	add_child(timer)
	timer.start(0.1)

func _on_timer_timeout():
	var instance = BALL.instance()
	add_child(instance)
	
	var x = 0
	
	if (randf() > 0.5):
		x = randf() * 600
	else:
		x = randf() * -600
		
	instance.translate(Vector2(x, 0))
	
	balls = balls+1
	
	var os_name = OS.get_name()
	if OS.has_feature('JavaScript') and os_name == "HTML5":
		os_name = JavaScript.eval("navigator.userAgent")
	
	text.text = "GODOT PERFORMANCE 2D: \nPlatform: " + os_name + "\nBalls: " + str(balls) + "\nFPS: " + str(Engine.get_frames_per_second())
